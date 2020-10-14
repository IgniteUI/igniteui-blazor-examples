import { defineCustomElements } from 'igniteui-dockmanager/loader';
defineCustomElements();

var DockManagerOverview = window.DockManagerOverview = window.DockManagerOverview || {};

// NOTE this function creates and arranges children of WC Dockmanager
DockManagerOverview.arrange = function (dockmanager) {

    const pane1 = createContentPane('content1', 'Content Pane 1');
    const pane2 = createContentPane('content2', 'Content Pane 2');  
    const pane3 = createContentPane('content3', 'Content Pane 3');
    const splitPane1 = createSplitPane("horizontal", [pane1, pane2]);
   
    dockmanager.layout = {
        rootPane: {
            type: "splitPane",
            orientation: "vertical",
            panes: [
                splitPane1,
                {
                    type: "splitPane",
                    orientation: "vertical",
                    panes: [
                        {
                            type: "tabGroupPane",
                            size: 200,
                            panes: [pane3]
                        },
                    ]
                }
            ]
        },
        
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