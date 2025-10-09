let index = 4;

window.addTile = () => {
    const tileManager = document.querySelector('igc-tile-manager');
    const tiles = tileManager.querySelectorAll('igc-tile');
    const newTile = document.createElement('igc-tile');
    const contentHeader = document.createElement('span');
    const content = document.createElement('p');
    index++;
    contentHeader.textContent = `Tile ${index} header`;
    content.textContent = `Content for Tile ${index}`;
    contentHeader.setAttribute('slot', 'title');
    newTile.position = 0;
    newTile.append(contentHeader);
    newTile.append(content);
    tileManager.insertBefore(newTile, tiles[3]);
};

window.removeTile = () => {
    const tileManager = document.querySelector('igc-tile-manager');
    const firstTile = tileManager.querySelector('igc-tile:first-of-type');

    if (firstTile) {
        firstTile.remove();
    }
}
