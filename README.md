# Introduction 
This repo contains a demo suite on how to use FitNesse with FitSharp and C# fixtures. It include FitNesse test pages as well as 
corresponding C# fixtures.

# Getting Started
1. Download FitNesse (http://fitnesse.org) and install it to C:\Apps\FitNesse
2. Download FitSharp (https://github.com/jediwhale/fitsharp) and install it to C:\Apps\FitNesse\FitSharp.
3. Clone the repo to a local folder (C:\Data\FitNesseDemo)
4. Update plugins.properties to point to the FitSharp folder (if you took other folders than suggested)
5. Build all projects in the solution TestSlim
6. Ensure you have Java installed (1.7 or higher)
7. Start FitNesse with the root repo folder as the data folder as well as the current directory:
	cd /D C:\Data\FitNesseDemo
	java -jar C:\Apps\FitNesse\fitnesse-standalone.jar -d .
8. Open a browser and enter the URL http://localhost:8080/FeatureDemoSuite?suite

# Contribute
Enter an issue or provide a pull request. 
