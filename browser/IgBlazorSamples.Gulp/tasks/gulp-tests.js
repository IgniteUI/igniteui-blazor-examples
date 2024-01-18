let gulp = require('gulp');
let fs = require('fs.extra');
let flatten = require('gulp-flatten');
let es = require('event-stream');

// var igConfig = require('./gulp-config.js')

function getPath(file) {
    var filePath = file.dirname + "\\" + file.basename;
    filePath = "..\\..\\samples\\" + filePath.split("\\samples\\")[1];
    filePath = filePath.split("\\").join("/");
    return filePath;
}

function verifyFile(file, fileCallback, requiredStrings) {

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
    fileCallback(null, file);
}

function testAppFiles(cb) {
    var checks = [
        { forbidden: "async void", valid: "async Task" },
        { forbidden: "@inject IIgniteUIBlazor IgniteUIBlazor" },
        { forbidden: "Register(IgniteUIBlazor)" },
        { forbidden: "Task.Delay(1);" },
        { forbidden: "Task.Delay(0);" },
    ];
    gulp.src([
        '../../samples/**/*.razor',
    //     '../../samples/layouts/expansion-panel/**/*.razor',
    //     '../../samples/layouts/accordion/**/*.razor',
    //    '!../../samples/layouts/accordion/**/*Imports.razor',
    //    '!../../samples/layouts/expansion-panel/**/*Imports.razor',
    ])
    // .pipe(es.map(verifySampleFile ))
    .pipe(es.map(function(file, fileCallback) {

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
        fileCallback(null, file);
    }))
    .on("end", function() { cb(); });
}

function testProjectFiles(cb) {

    var requiredStrings = [
        '<Project Sdk="Microsoft.NET.Sdk.BlazorWebAssembly">',
        '<NoWarn>1701;1702,IDE0028,BL0005,0219,CS1998</NoWarn>',
        '<TargetFramework>net8.0</TargetFramework>',
        '<RazorLangVersion>3.0</RazorLangVersion>',
        '<PackageReference Include="IgniteUI.Blazor.Trial" Version',
        '<PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly" Version="6.0.0" />',
        '<PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly.DevServer" Version="6.0.0" />',
        '</Project>',
    ];
    gulp.src([
        '../../samples/**/*.csproj',
        // '../../samples/layouts/expansion-panel/**/*.csproj',
    ])
    // .pipe(es.map(verifySampleFile ))
    .pipe(es.map(function(file, fileCallback) {
        verifyFile(file, fileCallback, requiredStrings);
    }))
    .on("end", function() { cb(); });
}

exports.testSampleFiles = testSampleFiles = gulp.series(
    testProjectFiles,
    testAppFiles,
);


function testCodeViewer(cb) {
    var contentKeep = `
<html/>
@code {
    protected override void OnInitialized()
    {
        var keep = true;
    }
}`;
    var contentSkip = `
    <html/>
    @code {

        protected override void OnInitialized()
        {

        }

        line1;

        line2;


        line3;
    }`;
    //var exp = /(protected override void OnInitialized\(\)\n\s*{\n\s*\n\s*})/gm;
    //var ret = contentSkip.replace(exp, '');
    var ret = contentSkip.replace(/\n\n\n/gm, '\n\n');
    console.log(contentSkip);
    console.log('testCodeViewer');
    console.log(ret);

    cb();
} exports.testCodeViewer = testCodeViewer;

