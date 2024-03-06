# Feature Demos ![workflow badge](../../actions/workflows/testslim-ci.yml/badge.svg)

## Introduction 
This repo contains a demo suite on how to use FitNesse with FitSharp and C# fixtures, primarily focusing on FitNesse Wiki capabilities. 
It include FitNesse test pages as well as corresponding C# fixtures.

## Installation
The steps to install are very similar to that of installing the [FibonacciDemo](../../../FitNesseFitSharpFibonacciDemo).

Differences are:
* Download the repo code as a zip file and extract the contents of the folder ``FitNesseFitSharpFeatureDemos-master`. 
* Go to solution folder: `cd /D %LOCALAPPDATA%\FitNesse\TestSlim`
* If you have .NET SDK installed:
    * Build fixture solution: `dotnet build --configuration release TestSlim.sln`
    * Go to fixture folder: `cd TestSlim`
    * Publish fixture: `dotnet publish --output bin\Deploy\net6.0 --framework net6.0 --configuration release TestSlim.csproj`
* If you do not have .NET SDK installed: download `TestSlim.zip` from the latest [release](../../releases) and extract it into `TestSlim\TestSlim`
* Go to the assembly folder `TestSlim\TestSlim\bin\Deploy\net6.0` and start FitNesse.
* Run the suite: Open a browser and enter the URL http://localhost:8080/FitSharpDemos.FeatureDemoSuite?suite

## Contribute
Enter an issue or provide a pull request. 
