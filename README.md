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
