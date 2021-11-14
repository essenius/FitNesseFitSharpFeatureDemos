# Introduction 
This repo contains a demo suite on how to use FitNesse with FitSharp and C# fixtures, primarily focusing on FitNesse Wiki capabilities. 
It include FitNesse test pages as well as corresponding C# fixtures.

# Installation
The steps to install are very similar to that of installing the [FibonacciDemo](../../../FitNesseFitSharpFibonacciDemo).

Differences are:
* Download the repo code as a zip file and extract the contents of the folder ``FitNesseFitSharpFeatureDemos-master`. 
* Go to solution folder: `cd /D %LOCALAPPDATA%\FitNesse\TestSlim`
* Build fixture solution: `dotnet build --configuration release TestSlim.sln`
* Go to fixture folder: `cd TestSlim`
* Publish fixture: `dotnet publish --output bin\Deploy\net5.0 --framework net5.0 --configuration release TestSlim.csproj`
* Go to the assembly folder and start FitNesse
* Run the suite: Open a browser and enter the URL http://localhost:8080/FitSharpDemos.FeatureDemoSuite?suite

# Contribute
Enter an issue or provide a pull request. 
