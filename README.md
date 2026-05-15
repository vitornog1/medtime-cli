 
 MedTime CLI - Bootcamp II - Etapa Intermediária
=======
Nome: Vítor Nogueira Lourenço
RA: 22503265
Professor: Romes Heriberto Pires de Araujo

## 🚀 Entrega Intermediária (Links)
- **Repositório GitHub:** [https://github.com/vitornog1/medtime-cli](https://github.com/vitornog1/medtime-cli)
- **Link do Deploy (Release v1.0.0):** https://github.com/vitornog1/medtime-cli/releases/tag/v1.0.0

- # 🛠️ Evolução (Etapa Intermediária)
Nesta fase, o projeto recebeu melhorias técnicas de integração e automação:
- **Integração com API:** Consumo da API **ViaCEP** para localização automática de farmácias/endereços.
- **Testes de Integração:** Implementação de testes automatizados validando o fluxo de ponta a ponta com serviços externos.
- **CI/CD:** Pipeline do GitHub Actions configurado para Build, Restore e Testes automáticos a cada commit.
- **Deploy:** Versão publicada oficialmente via GitHub Releases.

## ✨ Funcionalidades
- [x] Cadastrar medicamentos e horários
- [x] Listar medicamentos cadastrados
- [x] Marcar medicamentos como tomados
- [x] **Buscar endereço por CEP** (Integração API)
- [x] **Relatório de pendências**

## 🧪 Tecnologias e Ferramentas
- **Linguagem:** C# (.NET 10)
- **Integração:** HttpClient (ViaCEP API)
- **Testes:** xUnit
- **Automação:** GitHub Actions (YAML)

## ▶️ Como executar
```bash
dotnet run --project medtime-cli

# 💊 MedTime CLI

##  Descrição
Aplicação de linha de comando para controle de medicamentos e horários, voltada principalmente para idosos.

##  Problema
Muitos idosos esquecem de tomar seus medicamentos nos horários corretos, o que pode comprometer tratamentos de saúde.

##  Solução
A aplicação permite cadastrar medicamentos, listar e marcar como tomados.

##  Público-alvo
- Idosos
- Cuidadores
- Familiares

##  Funcionalidades
- Adicionar medicamento
- Listar medicamentos
- Marcar como tomado

## 🛠️ Tecnologias
- C#
- .NET


## ▶️ Como executar
```bash
dotnet run
```

##  Rodar testes
```bash
dotnet test
```

##  Rodar lint
```bash
dotnet format
```

##  Versão
1.0.0

##  Autor
Vítor Nogueira Lourenço

## Repositório
https://github.com/vitornog1/medtime-cli
