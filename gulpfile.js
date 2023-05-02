var gulp = require('gulp'),
    sevenBin = require('7zip-bin'),
    sevenZip = require('node-7z');

var app = 'Template';
var release = 'bin/Release/net6.0/win-x64/publish/';
var publish = 'bin/Publish/';

function publishToPlatform() {
    gulp.src([
        //include Sql resources
        'Sql/install.sql', 'Sql/uninstall.sql'
    ]).pipe(gulp.dest(publish + '/' + app + '/Sql', { overwrite: true }));

    gulp.src([
        //include views
        'Views/list-item.html'
    ]).pipe(gulp.dest(publish + '/' + app + '/Views', { overwrite: true }));

    return gulp.src([
        //include custom resources
        'editor.js', 'editor.less', 'LICENSE', 'README.md',
        //include all neccessary files from published folder
        release + 'Saber.Vendors.Template.dll'
    ]).pipe(gulp.dest(publish + '/' + app, { overwrite: true }));
}

gulp.task('publish:x64', () => {
    return publishToPlatform();
});

gulp.task('zip', () => {
    setTimeout(() => {
        //wait 500ms before creating zip to ensure no files are locked
        process.chdir(publish);
        sevenZip.add(app + '.7z', app, {
            $bin: sevenBin.path7za,
            recursive: true
        });
        process.chdir('../..');
    }, 500);
    return gulp.src('.');
});

gulp.task('publish', gulp.series('publish:x64', 'zip'));