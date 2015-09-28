var gulp = require('gulp');
var inject = require('gulp-inject');
var uglify = require('gulp-uglify');
var del = require('del');
var runSequence = require('run-sequence');
var gulpIf = require('gulp-if');
var config = { uglify: false };

gulp.task('default', ['compress'],function () {
    var target = gulp.src('./index.html');
    var sources = gulp.src(['./dist/js/app.js'], { read: false });
    return target.pipe(inject(sources, { ignorePath: 'dist' })).pipe(gulp.dest('./dist'));
   
});
gulp.task('compress', ['clean'], function () {
    console.log('uglify' + config.uglify);
    return gulp.src('./js/app.js', { base: '.' })
      .pipe(gulpIf(config.uglify,uglify()))
      .pipe(gulp.dest('dist'));
});
gulp.task('clean', function () {
    del(['./dist']);
});
gulp.task('build:production', function (callback) {
    config.uglify = true;
    runSequence('default',callback);
});
gulp.task('build', function (callback) {
    runSequence('default', callback);
});