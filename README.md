<!-- readme-seo: bannysukumar-professional-v4 -->

# Dotnet Learning

Dotnet Learning is a C# practice repository. The executable project `programme.csproj` targets `net8.0` and compiles `programme.cs` and `appsettings.cs`. Other `.cs` files in the root are separate samples for operators, loops, tuples, and a temperature converter.

## Overview

`programme.csproj` is an SDK-style console exe with nullable reference types and implicit usings. It references `Microsoft.Extensions.Configuration.Json` and `Microsoft.Extensions.Configuration.Binder` 8.0.0, and it includes `appsettings.json`. A second sample folder, `Hii`, is also in the repository.

## Features

Files in the repository root:

- `programme.cs` and `appsettings.cs`, compiled by `programme.csproj`
- `Operators.cs`, `forloop.cs`, `while.cs`, `foreach.cs`, `switch.cs`
- `Tuples.cs`, `TemperatureConverter.cs`, `User.cs`, `register.cs`
- `assending.cs`, `decending.cs`, and `null.cs`

## Tech Stack

| Technology | Where it shows up |
|---|---|
| C# | `.cs` files |
| .NET 8 | `TargetFramework` `net8.0` in `programme.csproj` |
| Configuration JSON | `Microsoft.Extensions.Configuration.Json` and `appsettings.json` |

## Project Structure

```text
Dotnet-Learning/
├── programme.csproj
├── programme.cs
├── appsettings.cs
├── appsettings.json
├── TemperatureConverter.cs
├── Operators.cs
└── Hii/
```

## Prerequisites

- .NET 8 SDK

## Installation

```bash
git clone https://github.com/Bannysukumar/Dotnet-Learning.git
cd Dotnet-Learning
dotnet run --project programme.csproj
```

Only `programme.cs` and `appsettings.cs` are included in that project. Open the other `.cs` files on their own if you want to read those samples.

## Configuration

`appsettings.json` is loaded by the configuration packages referenced in `programme.csproj`.

## Usage

Run the `programme` project with `dotnet run`. Read `TemperatureConverter.cs`, `Tuples.cs`, and the loop files as separate examples. They are not all compiled into `programme.csproj`.

## Contributing

Read [CONTRIBUTING.md](CONTRIBUTING.md) before opening a pull request.

## License

Licensed under MIT. See [LICENSE](LICENSE).

## Author

Banny Sukumar

GitHub: https://github.com/Bannysukumar
