# build-dotnet

Github action to build a dotnet app and receive the build output.

Builds and tests a dotnet app and stores the build output in a specified destination folder. Also stores a zipped version of the build in the destination folder.

```
- root
- - <Project-Folder>
- - - <Project.csproj>
- - <${{ build-output-path }}-Folder>
- - - <${{ runtime }}-Folder>
- - - - <Project.dll>
- - - <${{ name }}-${{ runtime }}.zip>
- - - - <Project.dll>
```

# Inputs

````yml
name:
    description: Name of the project
    required: false
    default: ''
  runtime:
    description: 'The rdi for the build'
    required: true
  version:
    description: 'Version for the build'
    required: false
  configuration:
    description: 'Configuration for the build'
    required: false
    default: 'Release'
  dotnet-version:
    description: '.NET version'
    required: false
    default: 7.0.x
  build-args:
    description: 'additional build arguments (e.g. --self-contained)'
    required: false
  build-output-path:
    description: 'folder name to contain the build output'
    required: false
    default: build
´´´

# Outputs

```yml
build-path:
description: Path to the build
value: ${{ steps.append-build-path.outputs.build-path }}
````
