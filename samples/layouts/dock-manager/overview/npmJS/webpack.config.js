var path = require('path');
var webpack = require('webpack');

module.exports = {
    mode: 'production',
    entry: {
      DockManagerOverview: [ "./src/DockManagerOverview.js",  ]
    },
    plugins: [ new webpack.optimize.LimitChunkCountPlugin({ maxChunks: 1 }) ],
    output: {
        path: path.join(__dirname, "../wwwroot"),
        publicPath: "../wwwroot/",
        filename: "[name].bundle.js"
    }
    // optimization: {
    //     splitChunks: false,
    //     concatenateModules: true
    // },
    // optimization: {
    //   runtimeChunk: false,
    //   splitChunks: {
    //     // chunks(chunk) {
    //     //   return false
    //     // },
    //     chunks: 'all',
    //     cacheGroups: {
    //       default: false,
    //       vendors: false,
    //       // vendor chunk
    //     },
    //   },
    // },
};