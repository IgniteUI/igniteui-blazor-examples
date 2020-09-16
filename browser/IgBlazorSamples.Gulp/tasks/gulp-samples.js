/* eslint-disable no-undef */
/* eslint-disable @typescript-eslint/no-var-requires */
/* eslint-disable @typescript-eslint/no-unused-vars */

let gulp = require('gulp');
var gulpChangeMod = require('gulp-chmod');
let gulpIgnore = require('gulp-ignore');
let uglify = require('gulp-uglify');

// let gSort = require('gulp-sort');
let rename = require('gulp-rename');
let fs = require('fs.extra');
let path = require('path');
let flatten = require('gulp-flatten');
let del = require('del');
let es = require('event-stream');
let shell = require('gulp-shell');
let replace = require('gulp-replace');
let contains = require('gulp-contains');

var igConfig = require('./gulp-config.js')
// var platform = "React";
// var igConfig = require('./gulp-config.js')[platform];

eval(require('typescript')
.transpile(require('fs')
.readFileSync("./tasks/Transformer.ts").toString()));

function log(msg) {
    console.log('GULP ' + msg);
}
log('loaded');

// NOTE you can comment out strings in this array to run subset of samples
var sampleSource = [
    igConfig.SamplesCopyPath + '/charts/category-chart/**/Pages/',
    igConfig.SamplesCopyPath + '/charts/data-chart/**/Pages/',
    igConfig.SamplesCopyPath + '/charts/doughnut-chart/**/Pages/',
    igConfig.SamplesCopyPath + '/charts/financial-chart/**/Pages/',
    igConfig.SamplesCopyPath + '/charts/pie-chart/**/Pages/',
    igConfig.SamplesCopyPath + '/charts/sparkline/**/Pages/',
    igConfig.SamplesCopyPath + '/charts/tree-map/**/Pages/',
    igConfig.SamplesCopyPath + '/charts/zoomslider/**/Pages/',
    igConfig.SamplesCopyPath + '/maps/geo-map/**/Pages/',
    igConfig.SamplesCopyPath + '/gauges/bullet-graph/**/Pages/',
    igConfig.SamplesCopyPath + '/gauges/linear-gauge/**/Pages/',
    igConfig.SamplesCopyPath + '/gauges/radial-gauge/**/Pages/',
    igConfig.SamplesCopyPath + '/grids/**/Pages/',
    // igConfig.SamplesCopyPath + '/layouts/**/Pages/',

    // igConfig.SamplesCopyPath + '/gauges/bullet-graph/animation/Pages/',
    // igConfig.SamplesCopyPath + '/grids/**/binding-live-data/Pages/',
    // igConfig.SamplesCopyPath + '/grids/**/column-types/Pages/',

    // igConfig.SamplesCopyPath + '/excel/excel-library/**/Pages/',
    // igConfig.SamplesCopyPath + '/excel/spreadsheet/**/Pages/',

    // excluding project's .razor files
    "!" + igConfig.SamplesCopyPath + '/**/App.razor',
    "!" + igConfig.SamplesCopyPath + '/**/Program.cs',
    "!" + igConfig.SamplesCopyPath + '/**/obj/**',
    "!" + igConfig.SamplesCopyPath + '/**/bin/**',
    "!" + igConfig.SamplesCopyPath + '/**/data-chart/type-scatter-polygon-series/Pages/',
    "!" + igConfig.SamplesCopyPath + '/**/data-chart/type-scatter-polyline-series/Pages/',
    // "!" + igConfig.SamplesCopyPath + '/**/App.razor',
    // "!" + igConfig.SamplesCopyPath + '/**/_Imports.razor',
    // "!" + igConfig.SamplesCopyPath + '/**/wwwroot/index.html',
    // "!" + igConfig.SamplesCopyPath + '/**/wwwroot/index.css',
];

// this variable stores detailed information about all samples in ./samples/ folder
var samples = [];

var sampleOutputFolder = '';

function cleanSamples() {
    // cleaning up obsolete files in individual samples
    // del.sync("../../samples/**/src/sandbox.config.json", {force:true});
    // del.sync("../../samples/**/manifest.json", {force:true});

    del.sync("../../samples/**/css/open-iconic/README.md", {force:true});
}
// lints all source files in ./samples folder and remove any routing paths (@page)
// since they are auto-generated when samples are copied to browsers
function lintSamples(cb) {
    for (const info of samples) {
        Transformer.lintSample(info, false)
    }
    cb();
} exports.lintSamples = lintSamples;

// lints only .razor files in ./samples folder and remove any routing paths (@page)
// since they are auto-generated when samples are copied to browsers
function lintRazorFiles(cb) {
    for (const info of samples) {
        Transformer.lintRazor(info, false)
    }
    cb();
} exports.lintRazorFiles = lintRazorFiles;

function saveSamples(cb) {
    for (const info of samples) {
        if (info.SourceRazorFile &&
            info.SourceRazorFile.Path &&
            info.SourceRazorFile.Content) {
            // log('saving ' + info.SourceRazorFile.Path)
        fs.writeFileSync(info.SourceRazorFile.Path, info.SourceRazorFile.Content);
        }
    }
    cb();
} exports.saveSamples = saveSamples;

function getSamples(cb) {

    // deleteSamples();
    // cleanSamples();

    samples = [];
    // del.sync("./sample-test-files/**/*.*", {force:true});

    gulp.src(sampleSource)
    // .pipe(gSort( { asc: false } ))
    .pipe(es.map(function(sample, sampleCallback) {

        let sampleFolder = Transformer.getRelative(sample.dirname);
        // console.log("get " + sampleFolder + '/' + sample.basename);
        // console.log("get " + sampleFolder + '/');

        let sampleFiles = [];
        gulp.src([
                sampleFolder + "/Pages/*",
                sampleFolder + "/Components/*",
                sampleFolder + "/Services/*",
                sampleFolder + "/*.csproj",
                sampleFolder + "/wwwroot/*.js",
                sampleFolder + "/wwwroot/*.css",
             // sampleFolder + "/wwwroot/*",
          '!' + sampleFolder + "/wwwroot/index.html",
          '!' + sampleFolder + "/wwwroot/index.css",
          '!' + sampleFolder + "/Pages/_*.razor",
          '!' + sampleFolder + "/Pages/*.g.cs",
          '!' + sampleFolder + "/obj/**",
          '!' + sampleFolder + "/obj/*.*",
          '!' + sampleFolder + "/bin/**",
          '!' + sampleFolder + "/bin/*.*",])
        .pipe(flatten({ "includeParents": -1 }))
        .pipe(es.map(function(file, fileCallback) {
            let fileDir = Transformer.getRelative(file.dirname);
            sampleFiles.push(fileDir + "/" + file.basename);
            // console.log("get file " + fileDir + "/" + file.basename);
            fileCallback(null, file);
        }))
        .on("end", function() {
            // log(sampleFolder);

            let sampleInfo = Transformer.getSampleInfo(sample, sampleFiles);
            if (sampleInfo !== null) {
                samples.push(sampleInfo);
            }
            sampleCallback(null, sample);
        });

        // sampleCallback(null, sample);
    }))
    .on("end", function() {
        Transformer.sort(samples);
        Transformer.process(samples);
        Transformer.verify(samples);

        // Transformer.print(samples);

        log('getSamples() found ' + samples.length + " samples");
        // for (const sample of samples) {
        //     log(' ' + sample.SampleFolderPath);
        // }
        // let last = samples[samples.length - 1];
        // log('package name ' + last.PackageFileContent.name);
        // last.PackageDependencies = Transformer.getDependencies(last);
        // log('packages \n' + last.PackageFileContent.dependencies);
        // log('dependencies: \n' + last.PackageDependencies);

        cb();
    });


} exports.getSamples = getSamples;



function makeDirectoryFor(filePath) {
    var dirname = path.dirname(filePath);
    if (fs.existsSync(dirname)) {
      return true;
    }
    makeDirectoryFor(dirname);
    fs.mkdirSync(dirname);
    // fs.mkdir(sampleOutputFolder + 'src', { recursive: true }, (err) => { if (err) throw err; });
}

function makeSamplesWritable(cb) {
    gulp.src(sampleSource)
        .pipe(gulpChangeMod(666))
        .pipe(gulp.dest(sampleSource))
        .on("end", function() {
            cb();
        });
} exports.makeSamplesWritable = makeSamplesWritable;

function exclude(fileWithString) {
    return es.map(function(file, cb) {
        if (file.basename.indexOf(fileWithString) >= 0 ||
            file.dirname.indexOf(fileWithString) >= 0) {
            // log('- share data ' + file.basename);
            cb(null);
        } else {
            // log('+ share data ' + file.basename);
            cb(null, file);
        }
    });
}

function cleanupSampleBrowser(outputPath) {
    log('cleaning up files in ' + outputPath);
    del.sync([
          outputPath + "/Services/*.*",   // auto-copied data files
          outputPath + "/Components/**",  // auto-copied sample's .razor components
          outputPath + "/wwwroot/*.js",   // auto-copied sample's .js files
          outputPath + "/Pages/**/*.*",   // auto-copied samples
          outputPath + "/Pages/**",       // auto-copied folders
    "!" + outputPath + "/Pages/_*.razor", // e.g. _Home.razor
    "!" + outputPath + "/Pages/_*.cshtml" // e.g. _Host.cshtml
    ], {force:true});
}

function saveFile(filePath, fileContent) {
    makeDirectoryFor(filePath);
    // if (!fs.existsSync(outputClientRazor)) {
    fs.writeFileSync(filePath, fileContent);
    //   console.log("copied " + filePath);
}

function copySamplePages(cb, outputPath) {

    log('copying samples to: ' + outputPath);
    // log('copying sample files... ');
    for (const sample of samples) {

        // lint and force auto-generation of routing paths (@page) in razor files
        Transformer.lintSample(sample, true);

        let sampleFolder = sample.ComponentGroup + '/' + sample.ComponentFolder
        // outputFolder = Strings.toTitleCase(outputClient);

        for (const file of sample.SourceFiles) {
            // log("copy " + sample.SampleRoute + " " + sample.ComponentFolder + " " + file.Path);
                // log("TO copy " + file.Path + '/' + file.Name);
            if (file.isRazorComponent()) {
                // log("copy " + file.Path);
                log("copying " + outputPath + '/Components/' + file.Name);
                saveFile(outputPath + '/Components/' + file.Name, file.Content);
            } else if (file.isRazorSample()) {
                log("copying " + outputPath + '/Pages/' + sampleFolder + '/' + file.Name);
                saveFile(outputPath + '/Pages/' + sampleFolder + '/' + file.Name, file.Content);
            } else {
                saveFile(outputPath + '/Services/' + file.Name, file.Content);
            }
        }
    }

    log('TOC generating with routing paths for samples');
    let routingGroups = Transformer.getRoutingGroups(samples);
    let routingFile = Transformer.getRoutingFile(routingGroups);

    log('TOC generating ' + outputPath + '/wwwroot/toc.json');
    saveFile(outputPath + '/wwwroot/toc.json', routingFile);

    cb();
}

function copySampleScripts(cb, outputPath, indexName) {
    var insertScriptFiles = [];

    log('copying scripts to: ' + outputPath + '/wwwroot/');
    for (const sample of samples) {
        for (const file of sample.PublicFiles_JS) {
            log("copying  " + outputPath + '/wwwroot/' + file.Name);
            saveFile(outputPath + '/wwwroot/' + file.Name, file.Content);
            insertScriptFiles.push('<script src="' + file.Name + '"></script>');
        }
    }

    // updating index.html with JavaScripts for samples
    let indexPath = outputPath + indexName;
    log('updating ' + indexPath);
    let indexFile = fs.readFileSync(indexPath).toString();
    let indexLines = indexFile.split('\n');
    let insertStart = -1;
    let insertEnd = -1;
    for (let i = 0; i < indexLines.length; i++) {
        let line = indexLines[i];
        if (line.indexOf("<!--AutoInsertJavaScriptsForSamples Start-->") > 0) {
            insertStart = i;
        }
        else if (line.indexOf("<!--AutoInsertJavaScriptsForSamples End-->") > 0) {
            insertEnd = i;
        }
    }

    if (insertStart > 0) {
        for (let i = insertStart+1; i < insertEnd; i++) {
            indexLines[i] = "";
        }
        indexLines[insertStart + 1] = insertScriptFiles.join('\n');
    }

    index = indexLines.join('\n');
    fs.writeFileSync(indexPath, index);
    // cb();
}

// '../../browser/IgBlazorSamples.Server/Pages'
// '../../browser/IgBlazorSamples.Server/Services'
// '../../browser/IgBlazorSamples.Server/wwwroot'
function copySamplesToServer(cb) {
    cleanupSampleBrowser( "../../browser/IgBlazorSamples.Server");
    copySampleScripts(cb, "../../browser/IgBlazorSamples.Server", "/Pages/_Host.cshtml");
    copySamplePages(cb,   "../../browser/IgBlazorSamples.Server");
} exports.copySamplesToServer = copySamplesToServer;

// '../../browser/IgBlazorSamples.Client/Pages'
// '../../browser/IgBlazorSamples.Client/Services'
// '../../browser/IgBlazorSamples.Client/wwwroot'
function copySamplesToClient(cb) {
    cleanupSampleBrowser( "../../browser/IgBlazorSamples.Client");
    copySampleScripts(cb, "../../browser/IgBlazorSamples.Client", "/wwwroot/index.html");
    copySamplePages(cb,   "../../browser/IgBlazorSamples.Client");
} exports.copySamplesToClient = copySamplesToClient;

function updateReadme(cb) {

    // log('updating readme files... ');
    var template = fs.readFileSync("./templates/sample/ReadMe.md", "utf8");
    for (const sample of samples) {

        // let outputPath = sampleOutputFolder + '/' + sample.SampleFolderPath;
        let outputPath = sampleOutputFolder + sample.SampleFolderPath + "/ReadMe.md";
        makeDirectoryFor(outputPath);
        // log(outputPath);
        let readmeFile = Transformer.updateReadme(sample, template);
        fs.writeFileSync(outputPath, readmeFile);
        // break;
    }
    cb();
} exports.updateReadme = updateReadme;

// updating package.json files for all sample using a template
function updateProjects(cb) {

    // del.sync("../../samples/**/css/open-iconic/README.md", {force:true});
    // del.sync("../../samples/**/css/open-iconic/BlazorClientApp.sln", {force:true});
    // del.sync("../../samples/**/css/open-iconic/BlazorClientApp.csproj", {force:true});
    // del.sync("../../samples/**/css/open-iconic/_Imports.razor", {force:true});
    // del.sync("../../samples/**/css/open-iconic/Program.cs", {force:true});
    // del.sync("../../samples/**/css/open-iconic/wwwroot", {force:true});
    // del.sync("../../samples/**/css/open-iconic/Properties", {force:true});

    // getting content of Project file from templates
    let templateProject = fs.readFileSync("../../templates/sample/BlazorClientApp.csproj");

    gulp.src(["../../samples/**/*.csproj"])
    // .pipe(flatten({ "includeParents": -1 }))
    .pipe(es.map(function(file, fileCallback) {
        let fileDir = Transformer.getRelative(file.dirname);

        if (file.dirname.indexOf("wwwroot") > 0 ||
            file.dirname.indexOf("Pages") > 0 ||
            file.dirname.indexOf("Services") > 0) {
            log("ERROR invalid project location: " + file.dirname)
        } else {
            let filePath = fileDir + "/" + file.basename;
            // let filePath = file.dirname + "/" + file.basename;
            let oldContent = file.contents.toString();
            var newContent = templateProject + '';
            if (newContent !== oldContent) {
                fs.writeFileSync(filePath, newContent);
                log('updated project: ' + filePath);
                // file.contents = new Buffer(newContent);
            }
        }
        // send the updated file down the pipe
        fileCallback(null, file);
    }))
    .on("end", function() {
        cb();
    });

    // for (const sample of samples) {
    //     if (sample.ProjectFile) {
    //         let outputPath = sample.ProjectFile.Path;
    //         let oldPackageFile = fs.readFileSync(outputPath).toString();
    //         let newPackageFile = templateProject + ''; // Transformer.updateProject(sample.ProjectFile);
    //         if (newPackageFile !== oldPackageFile) {
    //             log('updated: ' + outputPath);
    //             fs.writeFileSync(outputPath, newPackageFile);
    //         }
    //     }
    // }
    // gulp.src(sampleSource)
    // // .pipe(gSort( { asc: false } ))
    // .pipe(es.map(function(sample, sampleCallback) {

    //     let sampleFolder = Transformer.getRelative(sample.dirname);
    //     gulp.src([sampleFolder + "/*.csproj"])
    //     // .pipe(flatten({ "includeParents": -1 }))
    //     .pipe(es.map(function(file, fileCallback) {
    //         let fileDir = Transformer.getRelative(file.dirname);
    //         let filePath = fileDir + "/" + file.basename;
    //         let oldContent =  file.contents.toString();
    //         var newContent = templateProject + '';
    //         if (newContent !== oldContent) {
    //             log('updated: ' + filePath);
    //             file.contents = new Buffer(newContent);
    //         }
    //         // send the updated file down the pipe
    //         fileCallback(null, file);
    //     }))
    //     .on("end", function() {
    //         // cb();
    //         sampleCallback(null, sample);
    //     });
    // }))
    // .on("end", function() {
    //     cb();
    // });


} exports.updateProjects = updateProjects;


// updates ./public/meta.json with version in ./package.json file
function updateVersion(cb) {

    const appPackage = require('../package.json');
    const appVersion = appPackage.version;
    const jsonData = { version: appVersion, note: "this file is auto-generated" };
    const jsonContent = JSON.stringify(jsonData);
    const jsonPublicFile = './public/meta.json';

    fs.writeFile(jsonPublicFile, jsonContent, 'utf8', function(err) {
        if (err) {
            console.log('gulp cannot update ' + jsonPublicFile + ' file: \n' + err);
            return console.log(err);
        }
        console.log('gulp updated ' + jsonPublicFile + ' file with latest version number');
    });

    const jsonSourceFile = './src/CacheApp.json';
    fs.writeFile(jsonSourceFile, jsonContent, 'utf8', function(err) {
        if (err) {
            console.log('gulp cannot update ' + jsonSourceFile + ' file: \n' + err);
            return console.log(err);
        }
        console.log('gulp updated ' + jsonSourceFile + ' file with latest version number');
    });
    cb();

} exports.updateVersion = updateVersion;

function updateIndex(cb) {

    var template = fs.readFileSync("./templates/sample/src/index.tsx", "utf8");
    for (const sample of samples) {

        let outputPath = sampleOutputFolder + sample.SampleFolderPath + "/src/index.tsx";
        let oldIndexFile = fs.readFileSync(outputPath).toString();

        makeDirectoryFor(outputPath);
        let newIndexFile = Transformer.updateIndex(sample, template);
        if (newIndexFile !== oldIndexFile) {
            // log('updated: ' + outputPath);
            fs.writeFileSync(outputPath, newIndexFile);
        }
        // fs.mkdir(sampleOutputFolder + 'src', { recursive: true }, (err) => { if (err) throw err; });
        // fs.writeFileSync(outputPath, indexFile);
        // break;
    }
    cb();
} exports.updateIndex = updateIndex;

function updateSharedFiles(cb) {

    // always override these shared files
    gulp.src([
        './templates/sample/src/index.css',
        './templates/sample/src/react-app-env.d.ts',
        './templates/sample/sandbox.config.json',
        './templates/sample/tsconfig.json',
        './templates/sample/.gitignore',
        './templates/sample/.eslintrc.js',
    ])
    .pipe(flatten({ "includeParents": -1 }))
    .pipe(es.map(function(file, fileCallback) {
        let sourceContent = file.contents.toString();
        let sourcePath = Transformer.getRelative(file.dirname);
        sourcePath = sourcePath.replace('./templates/sample', '');
        sourcePath = sourcePath.replace('./templates/shared', '');

        for (const sample of samples) {
            // if (sample.isUsingFileName(file.basename)) {
                let samplePath = sampleOutputFolder + sample.SampleFolderPath;
                let targetPath = samplePath + sourcePath + '/' + file.basename;

                if (fs.existsSync(targetPath)) {
                    let targetContent = fs.readFileSync(targetPath, "utf8");
                    if (sourceContent !== targetContent) {
                        fs.writeFileSync(targetPath , sourceContent);
                        log('updated ' + targetPath);
                    }
                } else {
                    fs.writeFileSync(targetPath, sourceContent);
                    log('added ' + targetPath);
                }
        }
        fileCallback(null, file);
        // SourceFiles.push(fileDir + "/" + file.basename);
    }))

    // update these shared files if a sample is using them
    gulp.src(['./templates/shared/src/*.*'])
    .pipe(flatten({ "includeParents": -1 }))
    .pipe(es.map(function(file, fileCallback) {
        let sourceContent = file.contents.toString();
        let sourcePath = Transformer.getRelative(file.dirname);
        sourcePath = sourcePath.replace('./templates/sample', '');
        sourcePath = sourcePath.replace('./templates/shared', '');

        for (const sample of samples) {
            if (sample.isUsingFileName(file.basename)) {

                let samplePath = sampleOutputFolder + sample.SampleFolderPath;
                let targetPath = samplePath + sourcePath + '/' + file.basename;

                if (fs.existsSync(targetPath)) {
                    let targetContent = fs.readFileSync(targetPath, "utf8");
                    if (sourceContent !== targetContent) {
                        fs.writeFileSync(targetPath , sourceContent);
                        log('updated ' + targetPath);
                    }
                } else {
                    fs.writeFileSync(targetPath, sourceContent);
                    log('added ' + targetPath);
                }

                // let targetPath = sampleOutputFolder + sample.SampleFolderPath + '/src/' + file.basename;
                // let targetContent = fs.readFileSync(targetPath, "utf8");
                // if (sourceContent !== targetContent) {
                //     fs.writeFileSync(targetPath, sourceContent);
                //     // log('updated ' + file.basename + ' in ' + sample.SampleFilePath)
                //     log('updated ' + targetPath);
                // }
            }
        }
        fileCallback(null, file);
    }))
    .on("end", function() {
        cb();
    });


} exports.updateSharedFiles = updateSharedFiles;



// testing

function logRoutes(cb) {
    // getSamples();

    let index = 0;
    let routingGroups = Transformer.getRoutingGroups(samples);
    for (const group of routingGroups) {

        console.log('- group ' + group.Name);

        for (const component of group.Components) {

            console.log('- component ' + component.Name);
            for (const sample of component.Samples) {
                index++;
                console.log(index + ' ' + sample.SampleRoute + ' === ' + sample.SampleDisplayName);
            }
        }
    }

    cb();
} exports.logRoutes = logRoutes;

function logFile() {
    return es.map(function(file, cb) {
        let relative = Transformer.getRelative(file.dirname);
        log(relative + '/' + file.basename);
        // log(path.relative(path.join(file.cwd, file.base), file.path))
        cb(null, file);
    });
}

function logPublicFiles(cb) {
    gulp.src([
        './samples/**/public/*.*',
    ])
    .pipe(logFile())
    .on("end", function() { cb(); });
} exports.logPublicFiles = logPublicFiles;

function logSourceFiles(cb) {
    gulp.src([
        './samples/**/src/*.ts',
       '!./samples/**/src/index.*',
    ])
    .pipe(logFile())
    .on("end", function() { cb(); });
} exports.logSourceFiles = logSourceFiles;

function logRootFiles(cb) {
    gulp.src([
        './samples/**/*.*',
       '!./samples/**/src/*.*',
       '!./samples/**/*.tsx',
       '!./samples/**/*.ts',
       '!./samples/**/*.css',
       '!./samples/**/index.*',
       '!./samples/**/manifest.json',
       '!./samples/**/package.json',
       '!./samples/**/tsconfig.json',
    ])
    .pipe(es.map(function(file, cbFile) {
        let relative = Transformer.getRelative(file.dirname);
        log(file.basename + ' ' + relative + '/' + file.basename);
        cbFile(null, file);
    }))
    .on("end", function() { cb(); });
} exports.logRootFiles = logRootFiles;

function logUniqueFiles(cb) {

    let fileNames = [];
    gulp.src([
        './samples/**/src/*.ts',
       '!./samples/**/src/index.*',
    ])
    .pipe(es.map(function(file, cbFile) {
        if (fileNames.indexOf(file.basename) === -1) {
            fileNames.push(file.basename);
        }
        cbFile(null, file);
    }))
    .on("end", function() {
        fileNames.sort();
        for (const name of fileNames) {
            log(name);
        }
        cb();
    });

} exports.logUniqueFiles = logUniqueFiles;


function logSandboxUrls(cb) {

    for (const sample of samples) {
        console.log("" + sample.SandboxUrlShort);
    }
    cb();
} exports.logSandboxUrls = logSandboxUrls;



function copyTemplates(cb) {

    // del.sync("../../samples/**/.gitignore", {force:true});

    var sampleSource = [
        // '../../samples/charts/category-chart/**/*.md',
        // '../../samples/charts/data-chart/**/*.md',
        // '../../samples/charts/doughnut-chart/**/*.md',
        // '../../samples/charts/financial-chart/**/*.md',
        // '../../samples/charts/pie-chart/**/*.md',
        // '../../samples/charts/sparkline/**/*.md',
        // '../../samples/charts/tree-map/**/*.md',
        // '../../samples/charts/zoomslider/**/*.md',
        // '../../samples/maps/**/*.md',
        '../../samples/gauges/bullet-graph/**/*.md',
        '../../samples/gauges/linear-gauge/**/*.md',
        '../../samples/gauges/radial-gauge/**/*.md',
        // '../../samples/grids/**/*.md',
        '../../samples/layouts/**/*.md',
        // excluding *.md in node_modules sub folders
        // '../../samples/excel/excel-library/**/*.md',
        // '../../samples/excel/spreadsheet/**/*.md',
        "!" + '/**/node_modules/**/*.md',
    ];

    var sampleLocations = [];
    // del.sync("./sample-test-files/**/*.*", {force:true});

    gulp.src(sampleSource)
    // .pipe(gSort( { asc: false } ))
    .pipe(es.map(function(sampleFile, sampleCallback) {

        // let sampleFolder = '../.' + Transformer.getRelative(sampleFile.dirname);
        let sampleFolder = Transformer.getRelative(sampleFile.dirname);
        // console.log('copyTemplates ' + sampleFile.dirname + '   ' + sampleFile.basename);
        // log('copyTemplates ' + sampleFile.dirname + '   ' + sampleFolder);
        // // log(sampleFolder);
        sampleLocations.push(sampleFolder);

        // let sampleFiles = [];
        // gulp.src([sampleFolder + "/**"])
        // .pipe(flatten({ "includeParents": -1 }))
        // // .pipe(gSort( { asc: false } ))
        // .pipe(es.map(function(file, fileCallback) {
        //     console.log('getSamples ' + file.basename);
        //     // let fileDir = Transformer.getRelative(file.dirname);
        //     // sampleFiles.push(fileDir + "/" + file.basename);
        //     fileCallback(null, file);
        // }))
        // .on("end", function() {
        //     // log(sampleFolder);

        //     // let sampleInfo = Transformer.getSampleInfo(samplePackage, sampleFiles);
        //     // samples.push(sampleInfo);

        //     sampleCallback(null, sampleFile);
        // });

        sampleCallback(null, sampleFile);
    }))
    .on("end", function() {
        // Transformer.sort(samples);
        // Transformer.process(samples);

        // console.log('copyTemplates found ' + sampleLocations.length + " samples");

        // .pipe(gulp.dest('../samples/charts/category-chart/annotations'))

        for (const location of sampleLocations) {
            console.log('copyTemplates to ' + location);
            gulp.src([
                // '../../templates/sample/**',
                '../../templates/sample/**/*',
                // '../../templates/sample/.gitignore',
                // '../../templates/sample/.gitignore',
                // '../../templates/sample/wwwroot/*.*',
                // '../../templates/sample/Properties/*.*'
            ]) // , { base: 'sample' }
            // .pipe(es.map(function(templateFile, templateCallback) {
            //     let templateFolder = '.' + Transformer.getRelative(templateFile.dirname);
            //     console.log('updateSamples found ' + templateFolder + "  " + templateFile.basename);
            //     templateCallback(null, templateFile);
            // }))
            .pipe(gulp.dest(location))
        }

        console.log('copyTemplates to ' + sampleLocations.length + " samples");

        // let last = samples[samples.length - 1];
        // log('package name ' + last.PackageFileContent.name);
        // last.PackageDependencies = Transformer.getDependencies(last);
        // log('packages \n' + last.PackageFileContent.dependencies);
        // log('dependencies: \n' + last.PackageDependencies);

        cb();
    });
} exports.copyTemplates = copyTemplates;




