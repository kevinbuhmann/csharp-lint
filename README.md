# csharp-lint
[![Build Status](https://travis-ci.org/kevinphelps/csharp-lint.svg?branch=master)](https://travis-ci.org/kevinphelps/csharp-lint)
[![Build status](https://ci.appveyor.com/api/projects/status/eh3ttw06rapgn7k4/branch/master?svg=true)](https://ci.appveyor.com/project/kevinphelps/csharp-lint/branch/master)

Tool that uses the .NET Compiler Platform (Roslyn) and the StyleCop analyzers to provide static analysis (linting) of a single C# source file independent of its containing project.

## Usage

Windows: `CharpLint.exe \path\to\file.cs`
Linux: `mono CharpLint.exe /path/to/file.cs`

## Output

The program outputs an array of violations in JSON format. Each violation has these properties:
* `StartLine`: the line on which the violation starts
* `EndLine`: the line on which the violation ends
* `Id`: the id of the violation (CSxxxx or SAxxxx)
* `Message`: the error or warning message
* `Severity`: severity of the violation, 3 = Error; 2 = MajorWarning; 1 = MinorWarning
