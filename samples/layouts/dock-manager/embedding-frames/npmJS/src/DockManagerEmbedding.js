import { defineCustomElements } from 'igniteui-dockmanager/loader';
defineCustomElements();

var DockManagerEmbedding = window.DockManagerEmbedding = window.DockManagerEmbedding || {};

// NOTE this function creates and arranges children of WC Dockmanager
DockManagerEmbedding.arrange = function (dockmanager) {

    const pane1 = createContentPane('content1', "EMBEDDED RADIAL GAUGE");
    const pane2 = createContentPane('content2', "EMBEDDED DOUGHNUT CHART");
    const pane3 = createContentPane('content3', "EMBEDDED GEOGRAPHIC MAP");

    // const splitPane1 = createSplitPane("horizontal", [pane1, pane2], 300);
    // const splitPane2 = createSplitPane("horizontal", [pane3], 200);
    // const mainPane = createSplitPane("vertical", [splitPane1, splitPane2]);

    const splitPane1 = createSplitPane("horizontal", [pane3, pane2, pane1], 300);
    const mainPane = createSplitPane("vertical", [splitPane1]);

    dockmanager.layout = {
        rootPane: mainPane,
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
