# Introduction 
This repo contains a demo suite on how to use FitNesse with FitSharp and C# fixtures, primarily focusing on FitNesse Wiki capabilities. 
It include FitNesse test pages as well as corresponding C# fixtures.

# Installation
The steps to install are very similar to that of installing the [FibonacciDemo](../../../FitNesseFitSharpFibonacciDemo).

Differences are:
* Download the repo code as a zip file and extract the contents of the folder ```FitNesseFitSharpFeatureDemos```. 
* Build command becomes: `dotnet build %LOCALAPPDATA%\FitNesse\TestSlim\TestSlim.sln`
* Go to folder: `cd /D %LOCALAPPDATA%\FitNesse\TestSlim\TestSlim\bin\debug\net5.0`
* Run the suite: Open a browser and enter the URL http://localhost:8080/FeatureDemoSuite?suite

# Contribute
Enter an issue or provide a pull request. 
