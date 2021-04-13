# csharp-codewars
katas of codewars.

## Prerequisites 🔨

1. Install Windows 10 or Linux
2. Install dotnet version 2.1.700

## Installation 🔧

1. Install windows or linux.
2. Install dotnet-core 2.1.
   Download the dotnet from: https://dotnet.microsoft.com/download/dotnet-core/2.1

## Deploy 🚀

1. Clone project.

```
git clone https://github.com/RichardSeverich/csharp-codewars.git
```

2. Install dependencies: Enter to project and execute the following command:

```
dotnet build
```

3.  Execute unit test: Execute the following command:

Run all unit tests:

```
dotnet test
```

Run single test:

```
dotnet test --filter "FullyQualifiedName=YourNamespace.TestClass1.Test1"
dotnet test --filter "FullyQualifiedName=csharp_codewars.PrimeTest.Test1"
```

4. Install dependencies of Reports: Enter to project and execute the following command:

```
dotnet add package JUnitTestLogger --version 1.1.0
```

Generate reports .html extension
```
dotnet test --logger html -r reports
```

Generate reports .xml extension
```
dotnet test --logger "junit;LogFilePath=reports/test.xml"
```
