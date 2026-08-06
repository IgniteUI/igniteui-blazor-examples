/**
 * sample-theme.js
 *
 * Lets the docs site re-theme this samples browser while it is embedded in a
 * docs <Sample> iframe.
 *
 * The docs ThemingWidget dispatches `igd-theme-change`; the Sample widget
 * bridges that to `postMessage({ type: 'igd-sample-theme', theme, mode })` on
 * the frame, and re-posts the current selection on every iframe `load`. Here we
 * validate the sender and repoint the Ignite UI theme <link> elements.
 *
 * Dormant unless a trusted docs host asks for a theme.
 */
(function () {
    'use strict';

    var MESSAGE_TYPE = 'igd-sample-theme';
    var LINK_ATTR = 'data-igd-theme-link';
    var DARK_QUERY = '(prefers-color-scheme: dark)';

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

    // Newest <link> per key; swaps chain from here so rapid switching stays ordered.
    var links = {};
    var selected = null;

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
            hostname.lastIndexOf('.infragistics.com') === hostname.length - '.infragistics.com'.length;
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

    // Drops every stylesheet for this key except the newest, so an interrupted
    // swap can't leave a stale theme behind.
    function prune(key) {
        var all = document.head.querySelectorAll('link[' + LINK_ATTR + '="' + key + '"]');
        for (var i = 0; i < all.length; i++) {
            if (all[i] !== links[key] && all[i].parentNode) {
                all[i].parentNode.removeChild(all[i]);
            }
        }
    }

    function swap(key, href) {
        var current = links[key];
        if (!current || current.getAttribute('href') === href) {
            return;
        }

        // The replacement is loaded alongside the outgoing sheet and only takes
        // over once ready, so the sample never renders unstyled mid-swap.
        var next = current.cloneNode(false);
        next.setAttribute('href', href);

        var done = function () {
            next.removeEventListener('load', done);
            next.removeEventListener('error', done);
            prune(key);
        };
        next.addEventListener('load', done);
        next.addEventListener('error', done);

        current.parentNode.insertBefore(next, current.nextSibling);
        links[key] = next;
    }

    function applyTheme(theme, mode) {
        var resolved = resolveMode(mode);

        for (var key in HREFS) {
            if (Object.prototype.hasOwnProperty.call(HREFS, key)) {
                swap(key, HREFS[key](resolved, theme));
            }
        }

        var root = document.documentElement;
        root.setAttribute('data-igd-theme', theme);
        root.setAttribute('data-igd-mode', resolved);
        root.style.colorScheme = resolved;
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
            links[key] = document.head.querySelector('link[' + LINK_ATTR + '="' + key + '"]');
        }
    }

    window.addEventListener('message', onMessage);
    watchSystemMode();
})();
