// TODO move IgBlazorSamples.Gulp scripts to to this file (IgBlazorSamples.Core)

/// <binding BeforeBuild='copySamples' />
/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

let rename = require('gulp-rename');
let fs = require('fs.extra');
let path = require('path');
//let flatten = require('gulp-flatten');
//let del = require('del');
//let es = require('event-stream');
//let shell = require('gulp-shell');
//let replace = require('gulp-replace');
//let contains = require('gulp-contains');
var gulp = require('gulp');

gulp.task('default', function () {
    // place code for your default task here
    console.log('gulp default')
});

gulp.task('copySamples', function () {
    // place code for your default task here
    console.log('gulp copySamples')
});