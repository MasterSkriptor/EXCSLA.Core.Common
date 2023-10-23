# EXCSLA.Core.Common.Entities

The Core.ValueObjects.Common has the base domain models to implement aggregate roots, entities, and domain events.

## Installation
You can install this package in the following ways:

1. Dotnet CLI
> dotnet add package EXCSLA.Core.Entities --version 1.0.1

2. Add to csproj file.
> \<PackageReference Include="EXCSLA.Core.Entities" Version="1.0.1" /\>

3. Visual Studio Package Manager
> NuGet\Install-Package EXCSLA.Core.Entities -Version 1.0.1

## Description
The Core.ValueObjects.Common has the base domain models to implement aggregate roots, entities, and domain events.

### BaseEntity
Base class for DDD Entity objects. Handles equality based off of Id field. Inherit from this class for any domain entity that needs to be tracked by an Id.

### BaseAggregateRoot
Base class for DDD Aggregates. This class bakes domain events into the base entity.

### BaseDomainEvent
Base class for domain event. Adds DateOccured to the event for tracking when the event occured.
