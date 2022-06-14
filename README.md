
# Overview

This project is supposed to provide API of the Template.


# NuGet Package Products

In order to support the consumer, this project produces Template NuGet packages.

## Template

This package contains all the assemblies the consumer needs in order to make the goal of the Template.


# Build

You can build the product via command line:
```
PS> dotnet build .\Template.sln
```

## Build Output

All the build output is centralised underneath the output folder in the root of this repository.
It conatains a structure of main, test and nuget folders.
- The main folder contains all the assemblies in order to make the final product.
- The nuget folder contains all the NuGet packages created from the final product.
- The test folder contains all the assets requires to get the product tested at the build time.
