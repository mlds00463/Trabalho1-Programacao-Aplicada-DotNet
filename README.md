# Trabalho 1 — Programação Aplicada em .NET

Este repositório contém os três exercícios solicitados para o Trabalho 1 da disciplina Programação Aplicada em .NET.

## Exercício 1 — Pattern Matching

Aplicação Console que trabalha com empréstimos em uma biblioteca usando classes base e derivadas, com validação por meio de `switch expression` e `pattern matching`.

## Exercício 2 — Reflection

Aplicação Console que demonstra a leitura de propriedades públicas com Reflection e a filtragem de propriedades marcadas com um atributo personalizado.

## Exercício 3 — DTO

Aplicação Console que cria uma `Reserva` e mapeia para um DTO de saída usando `record`, ocultando informações internas do domínio.

## Como executar cada projeto

Os três projetos utilizam `net9.0`. Para executar, é necessário ter o runtime .NET 9 e um SDK compatível instalados.

A partir da pasta raiz, compile a solução com `dotnet build Trabalho1.slnx` (a restauração é automática) e execute cada projeto:

- `dotnet run --project Exercicio1/Exercicio1.csproj`
- `dotnet run --project Exercicio2/Exercicio2.csproj`
- `dotnet run --project Exercicio3/Exercicio3.csproj`

## Observação

A solução foi organizada em três projetos separados para facilitar execução e análise de cada exercício individualmente.
