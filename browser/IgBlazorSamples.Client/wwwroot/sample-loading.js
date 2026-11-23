/**
 * sample-loading.js
 *
 * Shows one loading indicator, not two, while this samples browser is embedded
 * in a docs <Sample> iframe.
 *
 * The docs widget draws its own indicator over the frame and hides it on the
 * frame's `load` event, but this WebAssembly app keeps booting long after that.
 * So, when a trusted docs page embeds it:
 *   - From <head>, before `load`, post `igd-sample-pending` to the parent and
 *     hide the `.sb-loading` gif.
 *   - The docs widget answers `igd-sample-pending-ack` and keeps its indicator
 *     up past `load`.
 *   - Once the app has rendered into <app>, post `igd-sample-ready`, and the
 *     docs widget hides its indicator.
 * A parent that never answers (an older docs page, or one without an indicator)
 * gets the gif back on `load`, when its own indicator would go.
 *
 * Dormant when not embedded, or embedded by an untrusted page: the gif shows as
 * before.
 */
(function () {
    'use strict';

    var PENDING_MESSAGE = 'igd-sample-pending';
    var PENDING_ACK_MESSAGE = 'igd-sample-pending-ack';
    var READY_MESSAGE = 'igd-sample-ready';
    // Set on <html> to hide the gif while the docs page shows its indicator.
    var HIDE_ATTR = 'data-igd-host-loading';

    // Same check as sample-theme.js.
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

    // Chromium and Safari name the embedding page's origin; Firefox only has the
    // referrer, which is empty under a `no-referrer` policy.
    function getParentOrigin() {
        var ancestors = window.location.ancestorOrigins;
        if (ancestors && ancestors.length) {
            return ancestors[0];
        }
        try {
            return new URL(document.referrer).origin;
        } catch (e) {
            return null;
        }
    }

    // Calls back once Blazor has rendered into <app>, replacing the gif. An empty
    // <app> doesn't count: the router renders nothing while it lazy-loads assemblies.
    function onAppRendered(callback) {
        var app = document.querySelector('app.sb-app');
        if (!app) {
            return;
        }
        var isRendered = function () {
            return app.firstElementChild !== null && !app.querySelector('.sb-loading');
        };
        if (isRendered()) {
            callback();
            return;
        }
        var observer = new MutationObserver(function () {
            if (isRendered()) {
                observer.disconnect();
                callback();
            }
        });
        observer.observe(app, { childList: true });
    }

    if (window.parent === window) {
        return;
    }

    var parentOrigin = getParentOrigin();
    if (!parentOrigin || !isTrustedOrigin(parentOrigin)) {
        return;
    }

    var root = document.documentElement;
    var acknowledged = false;

    // This script runs in <head>, before the gif is parsed, so it never shows.
    var style = document.createElement('style');
    style.textContent = 'html[' + HIDE_ATTR + '] .sb-loading { display: none; }';
    document.head.appendChild(style);
    root.setAttribute(HIDE_ATTR, '');

    window.addEventListener('message', function (event) {
        if (event.source !== window.parent || event.origin !== parentOrigin) {
            return;
        }
        if (event.data && event.data.type === PENDING_ACK_MESSAGE) {
            acknowledged = true;
            root.setAttribute(HIDE_ATTR, '');
        }
    });

    window.addEventListener('load', function () {
        if (!acknowledged) {
            root.removeAttribute(HIDE_ATTR);
        }
    });

    document.addEventListener('DOMContentLoaded', function () {
        // Not deferred to an animation frame: a background tab never runs one,
        // and the docs indicator fades out over a few frames anyway.
        onAppRendered(function () {
            window.parent.postMessage({ type: READY_MESSAGE }, parentOrigin);
        });
    });

    window.parent.postMessage({ type: PENDING_MESSAGE }, parentOrigin);
})();
