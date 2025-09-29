NameSorter

A simple .NET console application that sorts a list of names by last name first, then by given names.
Built with clean, SOLID principles, and includes automated tests and CI/CD pipeline with AppVeyor.

Features

Sorts names from a text file by last name, then given names

Supports 1 to 3 given names per person

Input/Output file paths configurable via appsettings.json

Automated unit tests with xUnit

CI/CD pipeline with AppVeyor (build, test, run, publish artifacts)

Build & Run
Prerequisites

.NET 8 SDK installed

Clone this repository

Run locally
dotnet build
dotnet run --project NameSorter

By default, the program:

Reads names from unsorted-names-list.txt

Writes sorted names to sorted-names-list.txt

Tests

Run unit tests with:

dotnet test

Configuration

File paths are set in appsettings.json:

{
"InputFile": "unsorted-names-list.txt",
"OutputFile": "sorted-names-list.txt"
}

Make sure appsettings.json is copied to the output directory (already configured in .csproj).

CI/CD Pipeline (AppVeyor)

This project includes an appveyor.yml pipeline that:

Restores, builds, and tests the solution

Runs the console app on unsorted-names-list.txt

Prints the sorted names in the CI log

Uploads sorted-names-list.txt as an artifact

Artifacts available after build:

Compiled binaries (bin/Release/)

sorted-names-list.txt

Project Structure
NameSorterSolution/
NameSorter.Core/ # Sorting logic & models
NameSorter/ # Console application
NameSorter.Tests/ # Unit tests (xUnit)
appsettings.json # Config for input/output files
unsorted-names-list.txt
appveyor.yml # CI/CD pipeline
README.md # Documentation

Example

Input (unsorted-names-list.txt):

Janet Parsons
Vaughn Lewis
Adonis Julius Archer
Shelby Nathan Yoder
Marin Alvarez

Output (sorted-names-list.txt):

Marin Alvarez
Adonis Julius Archer
Vaughn Lewis
Janet Parsons
Shelby Nathan Yoder
