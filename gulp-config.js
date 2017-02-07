module.exports = function() {
  var instanceRoot = "C:\\websites\\Habitat.commerce.dev.local";
  var config = {
    websiteRoot: instanceRoot + "\\Website",
    sitecoreLibraries: instanceRoot + "\\Website\\bin",
    licensePath: instanceRoot + "\\Data\\license.xml",
    solutionName: "Sitecore.Demo.Retail",
    buildConfiguration: "Debug",
    runCleanBuilds: false
  };
  return config;
}