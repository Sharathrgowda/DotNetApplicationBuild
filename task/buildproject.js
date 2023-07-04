var gulp = require("gulp");
var msbuild = require("gulp-msbuild");
const Logger = require('fancy-log');

var SourceCode = "D:/build/code/MVCCoreDemo.csproj"


gulp.task("ApplClean", function() {
	return gulp.src(SourceCode)
            .pipe(msbuild({
				// toolsVersion: '17.5.1',
                targets: ['Clean'], //Always do a CLEAN BUILD
                 properties: { Configuration: 'Release' }
				
                })
            )
            .on('end', function() {Logger.info(LogMessage='clean successfull'); })
            .on('error', function() {Logger.error(LogMessage='failed');});
});	

gulp.task("ApplBuild", function() {
	return gulp.src(SourceCode)
            .pipe(msbuild({
				// toolsVersion: '17.5.1',
                targets: ['Build'], //Always do a CLEAN BUILD
                properties: { Configuration: 'Release' }
				
                })
            )
            .on('end', function() {Logger.info(LogMessage='build successfull'); })
            .on('error', function() {Logger.error(LogMessage='failed');});
});	



function defaultTask(cb) {
  // place code for your default task here
  cb();
}

exports.default = defaultTask