import { defineCustomElements } from 'igniteui-dockmanager/loader';
defineCustomElements();

window.initDockManager = function (dockmanager) {

    const pane1 = createContentPane('content1', 'Content Pane 1');
    const pane2 = createContentPane('content2', 'Unpinned Pane 1');
    pane2.isPinned = false;

    const pane3 = createContentPane('content3', 'Document 1');
    const pane4 = createContentPane('content4', 'Document 2');

    const contentPane5 = createContentPane('content5', 'Unpinned Pane 2');
    contentPane5.isPinned = false;

    const pane6 = createContentPane('content6', 'Tab 1');
    const pane7 = createContentPane('content7', 'Tab 2');
    const pane8 = createContentPane('content8', 'Content Pane 2');
    const pane9 = createContentPane('content9', 'Floating Pane');

    const tabPane1 = createTabPane("horizontal", [pane3, pane4], 200);

    const splitPane1 = createSplitPane("vertical", [pane1, pane2]);
    const splitPane2 = createSplitPane("vertical", [tabPane1, contentPane5], 200);

    dockmanager.layout = {
        rootPane: {
            type: "splitPane",
            orientation: "horizontal",
            panes: [
                splitPane1,
                splitPane2,
                {
                    type: "splitPane",
                    orientation: "vertical",
                    panes: [
                        {
                            type: "tabGroupPane",
                            size: 200,
                            panes: [pane6, pane7]
                        },
                        pane8
                    ]
                }
            ]
        },
        floatingPanes: [
            {
                type: "splitPane",
                orientation: "horizontal",
                floatingHeight: 150,
                floatingWidth: 250,
                floatingLocation: { x: 800, y: 250 },
                panes: [pane9]
            }
        ]
    }
};

function createContentPane(contentID, paneHeader) {
    const pane = {
        header: paneHeader,
        type: "contentPane",
        contentId: contentID
    };
    return pane;
}

function createSplitPane(orientation, contentPanes, size) {
    const pane = {
        type: "splitPane",
        orientation: orientation,
        panes: contentPanes,
        size: size
    };
    return pane;
}

function createTabPane(orientation, contentPanes, size) {
    const pane = {
        type: "documentHost",
        size: size,
        rootPane: {
            type: "splitPane",
            orientation: orientation,
            panes: [
                {
                    type: "tabGroupPane",
                    panes: contentPanes
                }
            ]
        }
    };
    return pane;
}