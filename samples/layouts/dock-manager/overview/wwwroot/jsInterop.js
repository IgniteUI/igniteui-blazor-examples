import { defineCustomElements } from 'https://unpkg.com/igniteui-dockmanager@1.0.0-beta.4/loader/index.mjs';
defineCustomElements();

var jsInterop = window.jsInterop = window.jsInterop || {};

jsInterop.initDockManager = function (dockmanager) {

    var pane1 = {
        type: "contentPane",
        header: "Content Pane 1",
        contentId: "content1"
    };    

    var pane2 = {
        type: "contentPane",
        header: "Unpinned Pane 1",
        contentId: "content2",
        isPinned: false
    };

    var pane3 = {
        type: "contentPane",
        header: "Document 1",
        contentId: "content3"
    };

    var pane4 = {
        type: "contentPane",
        header: "Document 2",
        contentId: "content4"
    };

    var pane5 = {
        type: "contentPane",
        header: "Unpinned Pane 2",
        contentId: "content5",
        isPinned: false
    };

    var pane6 = {
        type: "contentPane",
        header: "Tab 1",
        contentId: "content6"
    };

    var pane7 = {
        type: "contentPane",
        header: "Tab 2",
        contentId: "content7"
    };

    var pane8 = {
        type: "contentPane",
        header: "Content 2",
        contentId: "content8"
    };

    var pane9 = {
        type: "contentPane",
        header: "Floating Pane",
        contentId: "content9"
    };

    var tabPane1 = {
        type: "documentHost",
        size: 200,
        rootPane: {
            type: "splitPane",
            orientation: "horizontal",
            panes: [
                {
                    type: "tabGroupPane",
                    panes: [
                        pane3,
                        pane4
                    ]
                }
            ]
        }
    };

    var splitPane1 = {
        type: "splitPane",
        orientation: "vertical",
        panes: [
            pane1,
            pane2
        ]
    };

    var splitPane2 = {
        type: "splitPane",
        orientation: "vertical",
        size: 200,
        panes: [
            tabPane1,
            pane5
        ]
    };

    var splitPane3 = {
        type: "splitPane",
        orientation: "vertical",
        panes: [
            {
                type: "tabGroupPane",
                size: 200,
                panes: [
                    pane6,
                    pane7
                ]
            }
        ]
    };

    var floatingSplitPane = {
        type: "splitPane",
        orientation: "horizontal",
        floatingHeight: 150,
        floatingWidth: 250,
        floatingLocation: { x: 300, y: 200 },
        panes: [
            pane9
        ]
    };

    dockmanager.layout = {
        rootPane: {
            type: "splitPane",
            orientation: "horizontal",
            panes: [              
                splitPane1,
                splitPane2,
                splitPane3
            ]
        },
        floatingPanes: [
            floatingSplitPane
        ]
    }
};
