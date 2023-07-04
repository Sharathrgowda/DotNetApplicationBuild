var gulp = require("gulp");
const Logger = require('fancy-log');



require('./task/buildproject');


gulp.task("ApplicationBuild", gulp.series('ApplClean','ApplBuild'), function(done) {
  Logger.info(LogMessage='build successfull');
  done();
});	


function defaultTask(cb) {
  // place code for your default task here
  cb();
}

exports.default = defaultTask
