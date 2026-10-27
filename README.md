# BibliotecaVirtual

**Português** | [English](README.en.md)

Protótipo de uma aplicação de console em **C# (.NET 8)** para uma biblioteca virtual: cadastro, listagem, pesquisa e empréstimo de livros, com os dados em memória.

> **Status: protótipo inicial, ainda não executável.** O `Program.cs` está vazio e o menu (`Interface/Menu.cs`) ainda não foi escrito, então o projeto não tem ponto de entrada e não roda.

## O que já existe

- **`Livro`** (domínio): título, autor, ano e situação de empréstimo, com os métodos `Emprestar()` e `Devolver()`.
- **`BibliotecaService`** (serviço, lista em memória):
  - cadastrar livro, recusando título repetido (sem diferenciar maiúsculas e minúsculas);
  - listar livros;
  - pesquisar por título;
  - emprestar livro.

A lógica de empréstimo e devolução ainda está incompleta e precisa de ajustes antes de ser ligada a um menu.

## Tecnologias

- **C#** / **.NET 8** (aplicação de console)
- **LINQ**

## Estrutura

```
BibliotecaVirtual/
├── BibliotecaVirtual.sln
└── BibliotecaVirtual/
    ├── Dominio/Livro.cs
    ├── Servicos/BibliotecaService.cs
    ├── Interface/Menu.cs     # ainda vazio
    └── Program.cs            # ainda vazio
```

## Como executar

Requisito: [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).

Quando o `Program.cs` e o menu forem implementados, o projeto poderá ser executado na raiz do repositório com:

```bash
dotnet run --project BibliotecaVirtual/BibliotecaVirtual.csproj
```

No estado atual, o build falha por falta de ponto de entrada.
