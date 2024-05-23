# dotnet-console-calculator

## TLDR;

1. fork this once for a team to a repository owned by your "prodmaster"
1. add each team member as a collaborator
1. run `git clone https://github.com/<prodmaster>/dotnet-console-calculator` and open the folder with the `calculator.sln` file in vs code
1. run `git checkout -b <your github username>` to get your own branch to work on
1. make changes to the tests and unit under test to implement your part of the project
1. follow instructions for pushing to the prodmaster's repository

## Testing

run your unit tests with `dotnet test`
run your console app with `dotnet run --project Calculator.Console`

## The Big idea

We made this project to compare and contrast manual and continuous integration workflows for developing an example app. 

### Manual workflow

The "prodmaster" does `git checkout prod` and then does `git merge origin/<person 1>` ... to integrate the team's changes from pull requests. When `dotnet test` shows all passing tests they push to the prod branch and make a release. This is still a fairly rigorous workflow compared to what you might find in a small company.

### Continuous Integration

The "prodmaster" uses the recommended dotnet workflow with github actions to add a workflow that merges to the prod branch automatically when a push is done on another branch and all of the tests pass.  

![recommended workflow](/READMEImages/RecommendedWorkflows.PNG)

Developers get the workflow on their branch and when they push to their branch the workflow is run to integrate with prod. If the tests pass the code is merged on to the prod branch. Prod is built and deployed either manually or automatically when a release is required. A company might combine this with cohort based testing and google analytics to deploy a new release each day and send an expanding cohort to the new release depending on the metrics selected for improvement.

## The making of this scaffold

I followed [this tutorial](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test).

1. `dotnet new sln -o calculator`
1. `dotnet new classlib -o Calculator`
1. `dotnet sln add ./Calculator/Calculator.csproj`
1. `dotnet new xunit -o Calculator.Tests`
1. `dotnet sln add ./Calculator.Tests/Calculator.Tests.csproj`
1. `dotnet add ./Calculator.Tests/Calculator.Tests.csproj reference ./Calculator/Calculator.csproj`
1. `dotnet new console -o Calculator.Console`
1. `dotnet sln add ./Calculator.Console/Calculator.Console.csproj`
1. `dotnet add ./Calculator.Console/Calculator.Console.csproj reference ./Calculator/Calculator.csproj`

Thank-you for reading right to the end. Please submit an issue to this repository if you find something. I have also turned on discussion so that you can create a thread there as you deem appropriate as well.

Thanks again

Rich


+++++++++++++++++++++++++++++++++++++++++++++++++++++++++
Added by Glaucia on May 23rd, 2024. 

To run this project with unit tests:

To run:

dotnet run --project .\Calculator.Console.csproj

To test:

dotnet test

To test with coverage:  (in folder where .sln file is:)

dotnet test --collect:"XPlat Code Coverage"

Then to make a report:

dotnet tool install --global dotnet-reportgenerator-globaltool
>> ~/.dotnet/tools/reportgenerator -reports:.\Calculator.Tests\TestResults\c5836b98-69da-49ba-a7ed-501b6abb994e\coverage.cobertura.xml -targetdir:reports