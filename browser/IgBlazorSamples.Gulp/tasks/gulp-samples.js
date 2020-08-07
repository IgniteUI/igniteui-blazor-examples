/* eslint-disable no-undef */
/* eslint-disable @typescript-eslint/no-var-requires */
/* eslint-disable @typescript-eslint/no-unused-vars */

let gulp = require('gulp');
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
    console.log('gulp-samples.js ' + msg);
}
log('loaded');

// NOTE you can comment out strings in this array to run subset of samples
var sampleSource = [
    // igConfig.SamplesCopyPath + '/charts/category-chart/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/charts/data-chart/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/charts/doughnut-chart/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/charts/financial-chart/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/charts/pie-chart/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/charts/sparkline/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/charts/tree-map/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/charts/zoomslider/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/maps/geo-map/**/Pages/*.razor',
    igConfig.SamplesCopyPath + '/gauges/bullet-graph/**/Pages/',
    // igConfig.SamplesCopyPath + '/gauges/linear-gauge/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/gauges/radial-gauge/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/grids/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/layouts/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/excel/excel-library/**/Pages/*.razor',
    // igConfig.SamplesCopyPath + '/excel/spreadsheet/**/Pages/*.razor',

    // excluding project's .razor files
    "!" + igConfig.SamplesCopyPath + '/Shared/*.razor',
    "!" + igConfig.SamplesCopyPath + '/**/App.razor',
    "!" + igConfig.SamplesCopyPath + '/**/_Imports.razor',
];

// this variable stores detailed information about all samples in ./samples/ folder
var samples = [];

var sampleOutputFolder = '';

function cleanSamples() {
    // cleaning up obsolete files in individual samples
    del.sync("./samples/**/src/sandbox.config.json", {force:true});
    del.sync("./samples/**/manifest.json", {force:true});
}

function lintSamples(cb) {
    for (const info of samples) {
        log('linting ' + info.SampleFolderPath)

        Transformer.lintSample(info)
    }
    cb();
} exports.lintSamples = lintSamples;

// function saveSamples(cb) {
//     for (const info of samples) {
//         log('saving ' + info.SampleFolderPath)
//         fs.writeFileSync(nfo.SampleFilePath, info.SampleFileSourceCode);
//     }
//     cb();
// } exports.saveSamples = saveSamples;

function lintSamples2(cb) {

    // del.sync("./sample-test-files/**/*.*", {force:true}); LinearGaugeLabels.tsx

    gulp.src([
        // './samples/tests2/**/**/LinearGaugeLabels.tsx',
        igConfig.SamplesCopyPath + '/gauges/bullet-graph/**/*.razor',
        // './templates/**/**/*.tsx',
        // './templates/**/**/*.ts',
        // './samples/**/**/**/*.tsx',
        igConfig.SamplesCopyPath + '/**/App.razor',
    ]) // , {base: './'}
    // .pipe(gSort( { asc: false } ))
    .pipe(es.map(function(file, fileCallback) {

        let fileLocation = Transformer.getRelative(file.dirname) + '/' + file.basename;
        let fileContent = file.contents.toString();
        // log('linting ' + fileLocation);

        // let newContent = Transformer.lintRazor(fileLocation, fileContent,
        //     (err, results) => {
        //       if (err) {
        //         fileCallback(err, null);
        //       }
        //     //   file.contents = Buffer.from(results);
        //     //   fileCallback(null, file);
        //     });
        // if (newContent !== fileContent) {
        //     log('changed: ' + fileLocation);
        //     file.contents = Buffer.from(newContent);
        //     // fileCallback(null, file);
        // } else {
        //     // fileCallback(null, null);
        // }
        fileCallback(null, file);
    }))
    .pipe(gulp.dest(igConfig.SamplesCopyPath))
    .on("end", function() {
        cb();
    });
}

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
        console.log("get " + sampleFolder + '/');

        let sampleFiles = [];
        gulp.src([
            sampleFolder + "/Pages/*",
            sampleFolder + "/Components/*",
            sampleFolder + "/Services/*",
            sampleFolder + "/wwwroot/*"])
        .pipe(flatten({ "includeParents": -1 }))
        .pipe(es.map(function(file, fileCallback) {
            let fileDir = Transformer.getRelative(file.dirname);
            sampleFiles.push(fileDir + "/" + file.basename);
            console.log("get file " + fileDir + "/" + file.basename);
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

        // Transformer.verify(samples);
        // Transformer.print(samples);

        log('getSamples found ' + samples.length + " samples");
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

function copyExclude(files) {
    return es.map(function(file, cb) {
        if (files.indexOf(file.basename) >= 0) {
            // log('+ share data ' + file.basename);
            cb(null, file);
        } else {
            // log('- share data ' + file.basename);
            cb(null);
        }
    });
}

function deleteSamples() {

    log('deleting sample files... ');
    del.sync("./src/samples/**/*.*", {force:true});
    del.sync("./src/samples/*.*", {force:true});
    del.sync("./src/samples/*", {force:true});

    // del.sync("./samples-test-files/public", {force:true});
    // del.sync("./samples-test-files/**/*.md", {force:true});
    // del.sync("./samples-test-files/**/*.ts", {force:true});
    // del.sync("./samples-test-files/**/*.css", {force:true});
    // del.sync("./samples-test-files/**/*.json", {force:true});
    // del.sync("./samples-test-files/*.json", {force:true});

}

function copySamples(cb) {

    deleteSamples();
    log('copying sample files... ');
    for (const sample of samples) {
        let outputPath = './src' + sample.SampleFolderPath.replace('.','');
        // log(outputPath);

        gulp.src([
              sample.SampleFolderPath + '/src/*.*',
        '!' + sample.SampleFolderPath + '/src/index.css',
        '!' + sample.SampleFolderPath + '/src/index.tsx',
        '!' + sample.SampleFolderPath + '/src/typedecls.d.ts',
        '!' + sample.SampleFolderPath + '/src/react-app-env.d.ts',
        '!' + sample.SampleFolderPath + '/sandbox.config.json',
        '!' + sample.SampleFolderPath + '/README.md',
        '!' + sample.SampleFolderPath + '/ReadMe.md',
        '!' + sample.SampleFolderPath + '/readme.md',
        '!' + sample.SampleFolderPath + '/package.json',
        '!' + sample.SampleFolderPath + '/package-lock.json',
        '!' + sample.SampleFolderPath + '/.eslintrc.js',
        '!' + sample.SampleFolderPath + '/.gitignore',
        ])
        // .pipe(copyExclude(['ReadMe.md', 'index.tsx']))
        // .pipe(logFile())
        .pipe(gulp.dest(outputPath))
    }

    let routingGroups = Transformer.getRoutingGroups(samples);

    for (const group of routingGroups) {
        let outputPath = "./src/samples/" + group.Name + "/RoutingData.ts";
        makeDirectoryFor(outputPath);

        // log('created ' + outputPath);
        let routingFile = Transformer.getRoutingFile(group);
        fs.writeFileSync(outputPath, routingFile);
    }

    cb();
} exports.copySamples = copySamples;

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
function updatePackages(cb) {

    // getting content of package.json file from templates
    let templatePackageFile = fs.readFileSync("./templates/sample/package.json");
    let templatePackageJson = JSON.parse(templatePackageFile.toString());

    // let last = samples[samples.length - 1];
    // let content = Transformer.getPackage(last, templatePackageJson);
    // fs.writeFileSync(sampleOutputFolder + "package.json", content);


    for (const sample of samples) {
        let outputPath = sampleOutputFolder + sample.SampleFolderPath + "/package.json";
        let oldPackageFile = fs.readFileSync(outputPath).toString();

        makeDirectoryFor(outputPath);

        let newPackageFile = Transformer.getPackage(sample, templatePackageJson);
        if (newPackageFile !== oldPackageFile) {
            // log('updated: ' + outputPath);
            fs.writeFileSync(outputPath, newPackageFile);
        }
    }

    cb();
} exports.updatePackages = updatePackages;

// updating browser's package.json file using template's package.json
function copyPackageJson(cb) {

    // getting content of package.json file from templates
    let templatePackageFile = fs.readFileSync("./templates/sample/package.json");
    let templatePackageJson = JSON.parse(templatePackageFile.toString());

    // getting content of package.json file from the browser
    let browserPackageFile = fs.readFileSync("./package.json");
    let browserPackageJson = JSON.parse(browserPackageFile.toString());

    let browserPackageNew = Transformer.updatePackage(browserPackageJson, templatePackageJson);
    if (browserPackageNew !== browserPackageFile) {
        fs.writeFileSync(sampleOutputFolder + "package.json", browserPackageNew);
        // console.log("updated browser's package.json file");
    }

    cb();
} exports.copyPackageJson = copyPackageJson;

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
        // SampleFiles.push(fileDir + "/" + file.basename);
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

function task1(cb) {
    log('task1  ');
    cb();
} exports.task1 = task1;

function task2(cb) {
    log('task2  ');
    cb();
} exports.task2 = task2;


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




