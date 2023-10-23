# EXCSLA.Core.Common.ValueObjects

The Core.Common.ValueObjects will contain any common values types needed on most or all websites / apis created by EXCSLA. These value objects can be added to Aggregates or Entities by simply referencing EXCSLA.Shared.Core.ValueObjects.Common and adding them as a property. Because they are value objects they are immutable, so you will need to add a new object instead of changing thier properties. Also steps will need to be taken to properly deal with them in any ORM you may use. For EF Core you will need to add OwnsOne, and optionally name the column name, in order to add them as columns in your database.

## Installation
You can install this package in the following ways:

1. Dotnet CLI
> dotnet add package EXCSLA.Core.Common.ValueObjects --version 1.0.1

2. Add to csproj file.
> \<PackageReference Include="EXCSLA.Core.Common.ValueObjects" Version="1.0.1" /\>

3. Visual Studio Package Manager
> NuGet\Install-Package EXCSLA.Core.Common.ValueObjects -Version 1.0.1

## Description
This package contains the following value objects to assist in creating Entities in any c# based application. They are designed to be created once and never updated, as per guidlines of Domain Driven Design and clean architecture.

### ValueObject
Base class for Value objects. This class overrides equal operatore for checking equality based off of all fields in the class. This code was sourced from the following link:
[https://github.com/jhewlett/ValueObject](https://github.com/jhewlett/ValueObject).

#### FullName
FullName is a standard human name value object.

### Email
A standard email address value object.

### PhoneNumber
A standard US based phone number.