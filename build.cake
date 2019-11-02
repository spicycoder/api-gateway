///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////
var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
///////////////////////////////////////////////////////////////////////////////
// SETUP / TEARDOWN
///////////////////////////////////////////////////////////////////////////////
Setup(ctx =>
{
   // Executed BEFORE the first task.
   Information("Running tasks...");
});
Teardown(ctx =>
{
   // Executed AFTER the last task.
   Information("Finished running tasks.");
});
///////////////////////////////////////////////////////////////////////////////
// Variables
///////////////////////////////////////////////////////////////////////////////
const string SolutionName = "./ApiGateway.sln";
///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////
Task("Clean")
   .Does(() =>
{
   DotNetCoreClean(
      SolutionName,
      new DotNetCoreCleanSettings
      {
         Configuration = configuration
      });
});
Task("Restore")
   .Does(() =>
{
   DotNetCoreRestore(SolutionName);
});
Task("Build")
   .Does(() =>
{
   DotNetCoreBuild(
      SolutionName,
      new DotNetCoreBuildSettings
      {
         Configuration = configuration,
         NoRestore = true,
      });
});
Task("Default")
   .IsDependentOn("Clean")
   .IsDependentOn("Restore")
   .IsDependentOn("Build");
RunTarget(target);