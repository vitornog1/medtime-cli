# MEDTIME CLI

Sistema de gerenciamento de medicamentos desenvolvido em C# (.NET) para auxiliar usuários no controle de horários e acompanhamento da medicação.

## Funcionalidades

* Cadastro de medicamentos
* Listagem de medicamentos cadastrados
* Marcação de medicamentos como tomados
* Visualização de medicamentos pendentes
* Consulta de cidade por CEP utilizando a API ViaCEP
* Armazenamento de dados em banco PostgreSQL na nuvem através do Supabase
* Testes automatizados
* Integração contínua com GitHub Actions

## Tecnologias Utilizadas

* C#
* .NET 10
* Supabase
* PostgreSQL
* ViaCEP API
* GitHub Actions
* xUnit

## Estrutura do Projeto

```text
medtime-cli/
│
├── Models/
├── Services/
├── MedTime.Tests/
├── .github/workflows/
├── Program.cs
└── README.md
```

## Como Executar

Clone o repositório:

```bash
git clone https://github.com/vitornog1/medtime-cli.git
```

Acesse a pasta:

```bash
cd medtime-cli
```

Execute o projeto:

```bash
dotnet run
```

## Menu Principal

```text
1 - Cadastrar medicamento
2 - Listar medicamentos
3 - Marcar como tomado
4 - Ver pendentes
5 - Buscar cidade por CEP
9 - Rodar teste
0 - Sair
```

## Banco de Dados

O projeto utiliza Supabase (PostgreSQL em nuvem) para persistência dos medicamentos cadastrados.

## API Externa

Integração com a API ViaCEP para consulta de endereços a partir do CEP informado pelo usuário.

## Testes

Executar os testes:

```bash
dotnet test
```

## CI/CD

O projeto utiliza GitHub Actions para execução automática de build e testes a cada push realizado no repositório.

## Autor

Vítor Nogueira

## Repositório

https://github.com/vitornog1/medtime-cli
