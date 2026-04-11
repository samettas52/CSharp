# CSharp — From Beginner to Pro .NET (Work in Progress)

A teaching / learning repository that collects C# examples, small projects and exercises covering core .NET concepts — intended to grow from beginner topics to professional patterns. This repository is actively being developed, so some folders contain complete examples while others are still being expanded. Consider this a living learning resource.

## Overview

This repo groups multiple small projects and sample code demonstrating:
- Basic C# syntax and program structure
- Object-oriented programming (classes, inheritance, interfaces)
- Access modifiers and encapsulation
- Constructors, methods and reference/value types
- Collections and Generics (Lists, etc.)
- Simple multi-project solutions (separation of Business, DataAccess, Entities, UI)
- Small console applications and practice exercises

Because the repository is not yet finalized, many examples are intentionally minimal and iterative. Expect additions, refactors and expanded documentation over time.

## Repository structure (high-level)

- .gitattributes, .gitignore
- CSharpIntro.sln — main solution file
- AccesModifiersTest/, AccessModifiers/ — examples about visibility and scope
- CSharpIntro/ — basic introduction samples
- Classes/, Classes2/ — examples of defining and using classes
- Constructors/ — constructor examples and patterns
- Generics/ — sample generic types and uses
- Inheritance/ — inheritance examples and polymorphism
- Interfaces/ — interface usage
- Lists/ — collection examples
- Methods/ — method examples and signatures
- Project1..Project4.* — small multi-project solution (Business, DataAccess, ConsoleUI, Entities)
- Properties/, ReferenceTypes/ — supporting examples

Note: File and folder names reflect learning topics; some folders may contain more than one sample project.

## Current status

- Many topic folders contain starter code and examples.
- Several projects are scaffolded but may lack full documentation, tests or production-ready structure.
- This repository is intentionally open-ended to allow iterative improvements and contributions.

## Requirements

- .NET SDK 6.0 or later (install from https://dotnet.microsoft.com/)
- Visual Studio 2022 / Visual Studio Code (with C# extensions) or another C# IDE
- Optional: dotnet CLI knowledge for building/running projects

## Quick start

1. Clone the repository:
   ```bash
   git clone https://github.com/samettas52/CSharp.git
   cd CSharp
