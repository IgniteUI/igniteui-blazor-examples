import { defineCustomElements } from 'igniteui-dockmanager/loader';
defineCustomElements();

var DockManagerUpdatingPanes = window.DockManagerUpdatingPanes = window.DockManagerUpdatingPanes || {};

// NOTE this function creates and arranges children of WC Dockmanager
DockManagerUpdatingPanes.arrange = function (dockmanager) {

    const pane1 = createContentPane('content1', "Managers List");
    const pane2 = createContentPane('content2', "Manager's Productivity");
    const pane3 = createContentPane('content3', "Managers Location");

    const splitPane1 = createSplitPane("vertical", [pane1]);
    const splitPane2 = createSplitPane("vertical", [pane2, pane3], 200);
    const mainPane = createSplitPane("horizontal", [splitPane1, splitPane2], 200);

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
