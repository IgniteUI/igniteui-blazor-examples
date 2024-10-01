/* eslint-disable no-undef */
/* eslint-disable @typescript-eslint/no-var-requires */

let gulp = require('gulp');

function log(msg) {
    console.log('GULP ' + msg);
}

var sb = require('./tasks/gulp-samples.js')

exports.getSamples = getSamples = gulp.series(
    sb.getSamples,
);

exports.updateReadme = updateReadme = gulp.series(
    sb.getSamples,
    sb.updateReadme,
);

exports.updateSamples = updateSamples = gulp.series(
    // sb.lintSamples,
    sb.getSamples,
    sb.updateReadme,
    // sb.updatePackages,
    // sb.updateIndex,
    sb.updateSharedFiles,
    sb.updateDataFiles,
);

exports.lintSamples = lintSamples = gulp.series(
    // sb.makeSamplesWritable,
    sb.getSamples,
    sb.lintSamples,
    sb.saveSamples,
);

exports.lintRazorFiles = lintRazorFiles = gulp.series(
    // sb.makeSamplesWritable,
    sb.getSamples,
    sb.lintRazorFiles,
    sb.saveSamples,
);

// exports.updateReadme = updateReadme = gulp.series(
//     sb.getSamples,
//     sb.updateReadme,
// );

exports.updateProjects = updateProjects = gulp.series(
    // sb.getSamples,
    sb.updateProjects,
);

// exports.updateSharedFiles = updateSharedFiles = gulp.series(
//     sb.getSamples,
//     sb.updateSharedFiles,
// );

exports.updateCodeViewer = updateCodeViewer = gulp.series(
    sb.getSamples,
    sb.updateCodeViewer,
);

exports.updateIG = updateIG = gulp.series(
    sb.updateIG,
);

exports.copySamplesToServer = copySamplesToServer = gulp.series(
    // sb.updateVersion,
    sb.getSamples,
    sb.copySamplesToServer,
);

exports.copySamplesToClient = copySamplesToClient = gulp.series(
    // sb.updateVersion,
    sb.getSamples,
    sb.copySamplesToClient,
    sb.updateCodeViewer,
    sb.updateReadme,
);
exports.updateBrowser = updateBrowser = copySamplesToClient;

exports.cleanupSampleBrowsers = cleanupSampleBrowsers = gulp.series(
    sb.cleanupSampleBrowsers,
);

exports.logSampleNames = sb.logSampleNames;
exports.removeSamplePages = sb.removeSamplePages;
exports.renameProjects = sb.renameProjects;

exports.convert = getSamples = gulp.series(
    sb.getSamples,
    sb.convertSamples,
);

// exports.updateVersion = updateVersion = sb.updateVersion;

// // exports.default = updateBrowser;
// exports.logPublicFiles = sb.logPublicFiles;
// exports.logSourceFiles = sb.logSourceFiles;
// exports.logUniqueFiles = sb.logUniqueFiles;
// exports.logRootFiles   = sb.logRootFiles;

exports.logRoutes = logRoutes = gulp.series(
    sb.getSamples,
    sb.logRoutes,
);

// exports.logSandboxUrls = logSandboxUrls = gulp.series(
//     sb.getSamples,
//     sb.logSandboxUrls,
// );

exports.copyTemplates = copyTemplates = gulp.series(
    sb.copyTemplates,
);


var gt = require('./tasks/gulp-tests.js')
exports.testSampleFiles = testSampleFiles = gulp.series(
    gt.testSampleFiles,
);

exports.cleanupSamples = cleanupSamples = sb.cleanupSamples;


var testGen = require('./tasks/gulp-generate-tests.js')
exports.generateTests = generateTests = gulp.series(
    testGen.generateTests,
)