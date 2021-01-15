/// <binding />
var gulp = require('gulp'),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    uglify = require('gulp-uglify');

var paths = {
    webroot: './wwwroot/'
};

paths.bootstrapCss = "./node_modules/bootstrap/dist/css/bootstrap.css";
paths.sbAdminCss = "./node_modules/startbootstrap-sb-admin-2/css/sb-admin-2.min.css";
paths.fontAwesomeCss = "./node_modules/@fortawesome/fontawesome-free/css/all.css";
paths.morrisCss = "./morris.js-0.5.1/morris.js-0.5.1/morris.css";

paths.jqueryJs = "./node_modules/jquery/dist/jquery.js";
paths.raphaelJs_1 = "./node_modules/michaelangelo/lib/arc.js";
paths.raphaelJs_2 = "./node_modules/michaelangelo/lib/baseElement.js";
paths.raphaelJs_3 = "./node_modules/michaelangelo/lib/circle.js";
paths.raphaelJs_4 = "./node_modules/michaelangelo/lib/ellipse.js";
paths.raphaelJs_5 = "./node_modules/michaelangelo/lib/path.js";
paths.raphaelJs_6 = "./node_modules/michaelangelo/lib/rectangle.js";

paths.morrisJs = "./morris.js-0.5.1/morris.js-0.5.1/morris.js";

paths.fonts = "./node_modules/@fortawesome/fontawesome-free/webfonts/*";


paths.jsDest = paths.webroot + "js";
paths.cssDest = paths.webroot + "css";
paths.fontDest = paths.webroot + "fonts";



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
        .pipe(concat(paths.jsDest + "/min/site.min.js"))
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
        .pipe(gulp.dest(paths.jsDest));

});






gulp.task("min:css", function () {

    return gulp.src([
        paths.bootstrapCss,
        paths.sbAdminCss,
        paths.fontAwesomeCss,
        paths.morrisCss])
        .pipe(concat(paths.cssDest + "/min/site.min.css"))
        .pipe(cssmin())
        .pipe(gulp.dest("."));

});




gulp.task("copy:css", function () {

    return gulp.src([
        paths.bootstrapCss,
        paths.sbAdminCss,
        paths.fontAwesomeCss,
        paths.morrisCss])
        .pipe(gulp.dest(paths.cssDest));

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




