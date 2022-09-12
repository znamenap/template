
# Overview

This project is supposed to provide API of the Contoso.


# NuGet Package Products

In order to support the consumer, this project produces Contoso NuGet packages.

## Contoso

This package contains all the assemblies the consumer needs in order to make the goal of the Contoso.


# Build

You can build the product via command line:
```
PS> dotnet build .\Contoso.sln
```

## Build Output

All the build output is centralised underneath the output folder in the root of this repository.
It conatains a structure of main, test and nuget folders.
- The main folder contains all the assemblies in order to make the final product.
- The nuget folder contains all the NuGet packages created from the final product.
- The test folder contains all the assets requires to get the product tested at the build time.

## Build Features

### Default Properties

The set of default build properties and assembly level attributes is declared in build/default.props file. You can update these values to match your needs. This properties file is referenced from every top level source directory's Directory.Build.props which gets evaluated by MS Build system.
The build project collects the most of the items required to collocated build convention and resources reused across the repository. This project has no output assets and follows guidance from MS Build SDK's [NoTargets](https://github.com/microsoft/MSBuildSdks/tree/main/src/NoTargets).
The central global.json collects the utilised project SDKs and serves to manage the versions centrally.

### Code Coverage

The code coverage is implemented via integration of the Coverlet and its MSBuild integration. You can control the build failure in build/default.props by updating the threshold limits. The guidance is at [Coverlet](https://github.com/coverlet-coverage/coverlet).

The output report is placed in output/reports/codecoverage.
By default it generates the Coverlet JSON format, Coberture format and HTML output.

### Central Package Version

The package version is managed centrally at build/Packages.props where you manually insert or update the packages and their versions. If you reference a package into a single project then the build fails as you should prevent this situation and rather update the central place.
The guidance is at [CentralPackageVersion](https://github.com/microsoft/MSBuildSdks/tree/main/src/CentralPackageVersions).

### Source Link

In order to benefit from debugging into the source this repo is also using guidance of [SourceLink](https://docs.microsoft.com/en-us/dotnet/standard/Ultron-guidance/sourcelink) by using the MS Build SDK's [SourceLink SDK](https://github.com/dotnet/sourcelink/blob/main/README.md). You should update global.json to use correct source link provider according to the host of the GIT repository.
