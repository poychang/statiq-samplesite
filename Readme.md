# Statiq Demo Site

Example of how to use Statiq .NET static-site generation with markdown files

## Installation

Clone the repo. This site makes use of the [statiq-theme-dbyll](https://github.com/poychang/statiq-theme-dbyll).

The theme is added as a GitSubmodule and lives within the `theme` folder.  You can see the submodule reference in `.gitmodules`.  You will need to pull the files from the sub-module before the site will work.  You can do that usign this command:

```
git submodule update --init --recursive
```

After you have the files you can build the site using:

```
dotnet run
```

You can then access the site locally using:

```
http://localhost:5080/
```

## Useful Documentation

- [Statiq website](https://www.statiq.dev/)
