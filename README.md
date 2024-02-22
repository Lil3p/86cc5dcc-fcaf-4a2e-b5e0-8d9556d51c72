# Coding Test Solution
Author : Tichaona Dhliwayo  

## Tooling
- Visual Studio 2022 with .Net 8 SDK
- Fine Code Coverage extension


## Verifying the solution
- Clone repository and open solution in visual studio, select Run All Test from the test menu
- All 11 test cases provided in assignment should pass
- Additional test for input string validation passes
- Additional test for edge case for one element in input string passes
- Additional test for returning the first occurrence of the longest subsequence when multiple longest subsequences exist passes


## Stretch goals implemented
### Continuous integration of solution using Github actions:
**dotnet-ci.yml** GitHub actions workflow file was added to the project to automate: 
- Building 
- Testing
- Code coverage reporting
- Dynamic versioning
- NuGet packaging 

### Code linting:
Linting was done using .NET Compiler Platform (Roslyn) Analyzers, default c# rules were configured in the
solution **.editorconfig** file, this file is processed by both visual studio and MSBuild  
 
### Code coverage: 
Unit test code coverage reporting was done using Coverlet and GitHub actions. 
Coverage report can be reviewed by navigating to the Actions tab, selecting the latest workflow run, and downloading the coverage artifact.
100% code coverage was achieved. 

During unit tests development code coverage was also reviewed using Fine Code Coverage visual studio extension.

### Solution containerisation using Docker:
Not implemented, solution developed as a class library and packaged as a NuGet package. 


