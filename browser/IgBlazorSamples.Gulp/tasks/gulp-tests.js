
let gulp = require('gulp');
let fs = require('fs.extra');
let path = require('path');
let flatten = require('gulp-flatten');
let del = require('del');
let es = require('event-stream');

// var igConfig = require('./gulp-config.js')

function getPath(file) {
    var filePath = file.dirname + "\\" + file.basename;
    filePath = "..\\..\\samples\\" + filePath.split("\\samples\\")[1];
    filePath = filePath.split("\\").join("/");
    return filePath;
}

function logIssue(file, msg) {
    var filePath = getPath(file);
    console.log(msg + " " + filePath)
}
function verifyFile(file, cbFile, requiredStrings) {

    var issues = [];
    var filePath = getPath(file);
    let content = file.contents.toString();
    for (const str of requiredStrings) {
        if (content.indexOf(str) < 0) {
            issues.push(filePath + " - Missing: " + str);
        }
    }
    if (issues.length > 0) {
        // console.log("Found issues in " + getPath(file) + " file:");
        console.log(issues.join('\n'));
    }
    cbFile(null, file);
}


function testAppFiles(cb) {

    var checks = [
        { forbidden: "async void", valid: "async Task" },
        { forbidden: "@inject IIgniteUIBlazor IgniteUIBlazor" },
        // { forbidden: "RegisterIconRef" },
    ];
    gulp.src([
        '../../samples/layouts/expansion-panel/**/*.razor',
        '../../samples/layouts/accordion/**/*.razor',
       '!../../samples/layouts/accordion/**/*Imports.razor',
       '!../../samples/layouts/expansion-panel/**/*Imports.razor',
    ])
    // .pipe(es.map(verifySampleFile ))
    .pipe(es.map(function(file, cbFile) {

        var issues = [];
        let content = file.contents.toString();
        var filePath = getPath(file);
        for (const item of checks) {
            if (content.indexOf(item.forbidden) >= 0) {
                if (item.valid)
                    issues.push(filePath + " - File should use '" + item.valid + "' instead of '" + item.forbidden + "'");
                else
                    issues.push(filePath + " - File should not contain '" + item.forbidden + "'");
            }
        }
        if (issues.length > 0) {
            //console.log("Found issues in " + getPath(file) + " file:");
            console.log(issues.join('\n'));
        }

        // if (fileNames.indexOf(file.basename) === -1) {
        //     fileNames.push(file.basename);
        // }
        // let content = file.contents.toString();
        //console.log("testAppFiles " + filePath);
        cbFile(null, file);
    }))
    .on("end", function() { cb(); });
}

function testProjectFiles(cb) {

    var requiredStrings = [
        '<Project Sdk="Microsoft.NET.Sdk.BlazorWebAssembly">',
        '<TargetFramework>net6.0</TargetFramework>',
        '<RazorLangVersion>3.0</RazorLangVersion>',
        '<PackageReference Include="IgniteUI.Blazor" Version',
        '<PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly" Version="6.0.0" />',
        '<PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly.DevServer" Version="6.0.0" />',
        '</Project>',
    ];
    gulp.src([
        '../../samples/layouts/expansion-panel/**/*.csproj',
    ])
    // .pipe(es.map(verifySampleFile ))
    .pipe(es.map(function(file, cbFile) {
        verifyFile(file, cbFile, requiredStrings);
    }))
    .on("end", function() { cb(); });
}

exports.testSampleFiles = testSampleFiles = gulp.series(
    testProjectFiles,
    testAppFiles,
);

// function testSampleFiles(cb) {

// } exports.testSampleFiles = testSampleFiles;