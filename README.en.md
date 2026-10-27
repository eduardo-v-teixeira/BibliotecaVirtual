# BibliotecaVirtual

[Português](README.md) | **English**

A prototype of a **C# (.NET 8)** console application for a virtual library: add, list, search and lend books, with the data kept in memory.

> **Status: early prototype, not runnable yet.** `Program.cs` is empty and the menu (`Interface/Menu.cs`) has not been written, so the project has no entry point and does not run.

## What exists so far

- **`Livro`** (book, domain): title, author, year and loan state, with the `Emprestar()` (lend) and `Devolver()` (return) methods.
- **`BibliotecaService`** (service, in-memory list):
  - add a book, rejecting a duplicate title (case-insensitive);
  - list books;
  - search by title;
  - lend a book.

The lend and return logic is still incomplete and needs fixes before it is wired to a menu.

## Tech stack

- **C#** / **.NET 8** (console application)
- **LINQ**

## Structure

```
BibliotecaVirtual/
├── BibliotecaVirtual.sln
└── BibliotecaVirtual/
    ├── Dominio/Livro.cs
    ├── Servicos/BibliotecaService.cs
    ├── Interface/Menu.cs     # still empty
    └── Program.cs            # still empty
```

## How to run

Requirement: [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).

Once `Program.cs` and the menu are implemented, the project can be run from the repository root with:

```bash
dotnet run --project BibliotecaVirtual/BibliotecaVirtual.csproj
```

In its current state the build fails because there is no entry point.
