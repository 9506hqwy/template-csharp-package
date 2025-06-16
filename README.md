# Template for C# Package

This repository provides a template for C# package.

## Prepare

1. Rename sln file name, and replace `dotnet.defaultSolution` in the *.vscode/settings.json*.
2. Remove example package project and test project.

## Development

### Formatting

Format source code.

```sh
dotnet format
```

### Testing

Execute test code.

```sh
dotnet test
```

### Updating

Check newer depenency crate.

```sh
dotnet list package --outdated
```

### License Checking

TODO

### Documentation

Generate API document.

```sh
docfx doc/docfx.json
```

### Build Artifacts

Build packages.

```sh
dotnet pack -o ./artifacts
```
