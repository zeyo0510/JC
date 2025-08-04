$BIN_HOME = "${env:WINDIR}\Microsoft.NET\Framework\v4.0.30319"
##################################################
$msbuild = "$BIN_HOME\MSBuild.exe"
##################################################
& $msbuild "JC.App.DotnetFrameworkViewer.sln"
##################################################
pause