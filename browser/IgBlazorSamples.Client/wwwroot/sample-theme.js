/**
 * sample-theme.js
 *
 * Lets the docs site re-theme this samples browser while it is embedded in a
 * docs <Sample> iframe.
 *
 * The docs ThemingWidget dispatches `igd-theme-change`; the Sample widget
 * bridges that to `postMessage({ type: 'igd-sample-theme', theme, mode })` on
 * the frame, and re-posts the current selection on every iframe `load`. Here we
 * validate the sender, repoint the Ignite UI theme <link> elements and provide
 * the selection to the web components as their theme context.
 *
 * Dormant unless a trusted docs host asks for a theme.
 */
(function () {
    'use strict';

    var MESSAGE_TYPE = 'igd-sample-theme';
    var LINK_ATTR = 'data-igd-theme-link';
    var DARK_QUERY = '(prefers-color-scheme: dark)';

    // The theme stylesheets only carry the palette, typography and other global
    // variables; each Shadow DOM component adopts its own per-theme styles from
    // the nearest theme provider, which it looks up with a bubbling, composed
    // `context-request` event for this key (the Lit context protocol that
    // <igc-theme-provider> answers). Answering it on the window makes this script
    // the provider for every component on the page, including ones rendered
    // outside the app root (tile drag ghosts) and ones from separately bundled
    // packages (GridLite), with no wrapper element and nothing extra to load.
    var THEME_CONTEXT = 'ig-theme-context';

    var THEMES = ['material', 'fluent', 'bootstrap', 'indigo'];

    // Keyed by the LINK_ATTR value on each stylesheet in index.html. Hrefs stay
    // relative so they keep resolving against the deployed <base>.
    var HREFS = {
        components: function (mode, theme) {
            return '_content/IgniteUI.Blazor/themes/' + mode + '/' + theme + '.css';
        },
        grid: function (mode, theme) {
            return '_content/IgniteUI.Blazor/themes/grid/' + mode + '/' + theme + '.css';
        }
    };

    // The <link> in effect per key, and the replacements a pending selection is loading.
    var activeLinks = {};
    var stagedLinks = [];
    // The newest selection, and the one whose stylesheets are in effect.
    var selected = null;
    var applied = null;
    // Bumped per applied selection, so only the newest one can take effect.
    var latestRequest = 0;

    // Handed to the components; undefined until a docs theme is applied, which
    // they ignore, keeping the global theme they would have without this script.
    var themeContext;
    // Each subscribed component's context callback, mapped to its unsubscribe.
    var subscribers = new Map();

    function isTrustedOrigin(origin) {
        if (origin === window.location.origin) {
            return true;
        }

        var hostname;
        try {
            hostname = new URL(origin).hostname;
        } catch (e) {
            return false;
        }

        if (hostname === 'localhost' || hostname === '127.0.0.1') {
            return true;
        }
        return hostname === 'infragistics.com' ||
            hostname.endsWith('.infragistics.com');
    }

    function parseMessage(data) {
        if (!data || typeof data !== 'object') {
            return null;
        }
        if (data.type !== MESSAGE_TYPE && data.event !== MESSAGE_TYPE) {
            return null;
        }

        var theme = String(data.theme || data.themeName || '').toLowerCase();
        if (THEMES.indexOf(theme) === -1) {
            return null;
        }

        var rawMode = String(data.mode || 'light').toLowerCase();
        var mode = (rawMode === 'dark' || rawMode === 'system') ? rawMode : 'light';

        return { theme: theme, mode: mode };
    }

    function resolveMode(mode) {
        if (mode === 'light' || mode === 'dark') {
            return mode;
        }
        return window.matchMedia && window.matchMedia(DARK_QUERY).matches ? 'dark' : 'light';
    }

    function onContextRequest(event) {
        if (event.context !== THEME_CONTEXT) {
            return;
        }
        event.stopPropagation();

        var callback = event.callback;
        if (!event.subscribe) {
            callback(themeContext);
            return;
        }
        // Components unsubscribe when they disconnect, so this only ever holds
        // the ones on the page.
        if (!subscribers.has(callback)) {
            subscribers.set(callback, function () {
                subscribers.delete(callback);
            });
        }
        callback(themeContext, subscribers.get(callback));
    }

    function provideTheme(theme, variant) {
        if (themeContext && themeContext.theme === theme && themeContext.variant === variant) {
            return;
        }
        themeContext = { theme: theme, variant: variant };
        subscribers.forEach(function (unsubscribe, callback) {
            callback(themeContext, unsubscribe);
        });
    }

    // Drops the stylesheets a superseded or failed selection was loading; they
    // never applied, so this can't leave the page unstyled.
    function removeStaged() {
        stagedLinks.forEach(function (link) {
            if (link.parentNode) {
                link.parentNode.removeChild(link);
            }
        });
        stagedLinks = [];
    }

    function applyTheme(theme, mode) {
        var resolved = resolveMode(mode);
        var request = ++latestRequest;
        var selection = { theme: theme, mode: mode };
        var incoming = {};
        var pending = 0;
        var failed = false;

        removeStaged();

        // Everything switches in one step once every new stylesheet is in: the
        // palette, the root attributes sample CSS keys on, and the components'
        // own styles, so no frame mixes the old theme with the new one.
        var commit = function () {
            for (var key in incoming) {
                var outgoing = activeLinks[key];
                incoming[key].removeAttribute('media');
                outgoing.parentNode.removeChild(outgoing);
                activeLinks[key] = incoming[key];
            }
            stagedLinks = [];
            applied = selection;

            var root = document.documentElement;
            root.setAttribute('data-igd-theme', theme);
            root.setAttribute('data-igd-mode', resolved);
            root.style.colorScheme = resolved;

            provideTheme(theme, resolved);
        };

        var onLoad = function () {
            if (!failed && request === latestRequest && --pending === 0) {
                commit();
            }
        };

        // Keeps the current theme and forgets the failed selection, so choosing
        // it again retries instead of being skipped as a repeat.
        var onError = function () {
            if (!failed && request === latestRequest) {
                failed = true;
                removeStaged();
                selected = applied;
            }
        };

        for (var key in HREFS) {
            if (!Object.prototype.hasOwnProperty.call(HREFS, key) || !activeLinks[key]) {
                continue;
            }
            var href = HREFS[key](resolved, theme);
            if (activeLinks[key].getAttribute('href') === href) {
                continue;
            }

            // media="print" fetches the stylesheet without applying it before commit.
            var link = activeLinks[key].cloneNode(false);
            link.setAttribute('href', href);
            link.setAttribute('media', 'print');
            link.addEventListener('load', onLoad);
            link.addEventListener('error', onError);
            activeLinks[key].parentNode.insertBefore(link, activeLinks[key].nextSibling);
            stagedLinks.push(link);
            incoming[key] = link;
            pending++;
        }

        if (pending === 0) {
            commit();
        }
    }

    function onMessage(event) {
        // Only the embedding docs page may drive the theme.
        if (event.source !== window.parent || !isTrustedOrigin(event.origin)) {
            return;
        }

        var next = parseMessage(event.data);
        if (!next) {
            return;
        }
        if (selected && selected.theme === next.theme && selected.mode === next.mode) {
            return;
        }

        selected = next;
        applyTheme(next.theme, next.mode);
    }

    function watchSystemMode() {
        var query = window.matchMedia && window.matchMedia(DARK_QUERY);
        if (!query || !query.addEventListener) {
            return;
        }
        query.addEventListener('change', function () {
            if (selected && selected.mode === 'system') {
                applyTheme(selected.theme, selected.mode);
            }
        });
    }

    if (window.parent === window) {
        return;
    }

    for (var key in HREFS) {
        if (Object.prototype.hasOwnProperty.call(HREFS, key)) {
            activeLinks[key] = document.head.querySelector('link[' + LINK_ATTR + '="' + key + '"]');
        }
    }

    // index.html loads this script before any component bundle, so every
    // component's theme request reaches this listener.
    window.addEventListener('context-request', onContextRequest);
    window.addEventListener('message', onMessage);
    watchSystemMode();
})();
