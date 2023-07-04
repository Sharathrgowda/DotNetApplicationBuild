var gulp = require("gulp");
var msbuild = require("gulp-msbuild");
const Logger = require('fancy-log');


gulp.task("ApplicationBuild", function() {
	return gulp.src('D:\build\code\MVCCoreDemo.csproj' )
            .pipe(msbuild({
				toolsVersion: '17.5.1',
                targets: ['Clean', 'Build'], //Always do a CLEAN BUILD
                properties: { Configuration: 'Release' }
				
                })
            )
            .on('end', function() {Logger.info(LogMessage='build successfull'); })
            .on('error', function() {Logger.error(LogMessage='build failed');});
});	
function defaultTask(cb) {
  // place code for your default task here
  cb();
}

exports.default = defaultTask
