/// <binding />

'use strict';

var gulp = require('gulp'),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    uglify = require('gulp-uglify');

var paths = {
    webroot: './wwwroot/'
};

//paths.bootstrapCss1 = "./node_modules/bootstrap/dist/css/bootstrap.css";
paths.bootstrapCss2a = "./wwwroot/bootstrap-3.4.1-dist/css/bootstrap.css";
paths.bootstrapCss2b = "./wwwroot/bootstrap-3.4.1-dist/css/bootstrap-theme.css";

paths.sbAdminCss = "./node_modules/startbootstrap-sb-admin-2/css/sb-admin-2.min.css";
paths.fontAwesomeCss = "./node_modules/@fortawesome/fontawesome-free/css/all.css";
paths.morrisCss = "./morris.js-0.5.1/morris.js-0.5.1/morris.css";

paths.siteCss = "./wwwroot/css_custom/site.css";

paths.jqueryJs = "./node_modules/jquery/dist/jquery.js";
paths.raphaelJs_1 = "./node_modules/michaelangelo/lib/arc.js";
paths.raphaelJs_2 = "./node_modules/michaelangelo/lib/baseElement.js";
paths.raphaelJs_3 = "./node_modules/michaelangelo/lib/circle.js";
paths.raphaelJs_4 = "./node_modules/michaelangelo/lib/ellipse.js";
paths.raphaelJs_5 = "./node_modules/michaelangelo/lib/path.js";
paths.raphaelJs_6 = "./node_modules/michaelangelo/lib/rectangle.js";

paths.morrisJs = "./morris.js-0.5.1/morris.js-0.5.1/morris.js";

paths.fonts = "./node_modules/@fortawesome/fontawesome-free/webfonts/*";


paths.jsDest_copy = paths.webroot + "js_copy";
paths.jsDest_min = paths.webroot + "js_min";

paths.cssDest_copy = paths.webroot + "css_copy";
paths.cssDest_min = paths.webroot + "css_min";

paths.fontDest = paths.webroot + "webfonts";



gulp.task("min:js", function () {

    return gulp.src([
        paths.jqueryJs,
        paths.raphaelJs_1,
        paths.raphaelJs_2,
        paths.raphaelJs_3,
        paths.raphaelJs_4,
        paths.raphaelJs_5,
        paths.raphaelJs_6,
        paths.morrisJs])
        .pipe(concat(paths.jsDest_min + "/site.min.js"))
        .pipe(uglify())
        .pipe(gulp.dest("."));

});



gulp.task("copy:js", function () {

    return gulp.src([
        paths.jqueryJs,
        paths.raphaelJs_1,
        paths.raphaelJs_2,
        paths.raphaelJs_3,
        paths.raphaelJs_4,
        paths.raphaelJs_5,
        paths.raphaelJs_6,
        paths.morrisJs])
        .pipe(gulp.dest(paths.jsDest_copy));

});






gulp.task("min:css", function () {

    return gulp.src([
//        paths.bootstrapCss1,
        paths.bootstrapCss2a,
        paths.bootstrapCss2b,
        paths.sbAdminCss,
        paths.fontAwesomeCss,
        paths.morrisCss,
        paths.siteCss])
        .pipe(concat(paths.cssDest_min + "/site.min.css"))
        .pipe(cssmin())
        .pipe(gulp.dest("."));

});




gulp.task("copy:css", function () {

    return gulp.src([
//        paths.bootstrapCss1,
        paths.bootstrapCss2a,
        paths.bootstrapCss2b,
        paths.sbAdminCss,
        paths.fontAwesomeCss,
        paths.morrisCss,
        paths.siteCss])
        .pipe(gulp.dest(paths.cssDest_copy));

});






gulp.task("copy:fonts", function () {

    return gulp.src([paths.fonts])
        .pipe(gulp.dest(paths.fontDest));

});



gulp.task("min", gulp.series("min:js", "min:css"));

gulp.task("copy", gulp.series("copy:js", "copy:css", "copy:fonts"));



gulp.task('default', function () {

    return new Promise((resolve, reject) => {
        console.log("Running default...");
        resolve();

    });

});




