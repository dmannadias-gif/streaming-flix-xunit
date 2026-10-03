# 🎬 StreamingFlix

---

## 📌 Visão Geral da Aplicação

O **StreamingFlix** é uma solução em .NET projetada para demonstrar a implementação de regras de negócio de um serviço de streaming e sua validação por meio de testes unitários automatizados. 

A aplicação lida com três regras centrais de negócio:
1. **Classificação do Plano por Qualidade:** Define a categoria do plano (`BÁSICO`, `PADRÃO` ou `PREMIUM`) de acordo com a quantidade de telas simultâneas.
2. **Cálculo de Mensalidade com Desconto:** Aplica descontos progressivos (0%, 10% ou 20%) dependendo da quantidade de meses contratados.
3. **Controle de Acesso a Conteúdo Adulto:** Valida a permissão de acesso considerando a idade do usuário e a ativação do controle parental.

---

## 🛠️ Requisitos Técnicos e Versão do .NET

Para compilar, executar a aplicação e rodar as suítes de teste, certifique-se de atender aos seguintes requisitos:

* **SDK do .NET:** Versão **10.0** (ou superior).
* **Framework de Testes:** xUnit.
* **Ferramenta de Linha de Comando:** CLI do .NET (`dotnet`).
* **Git:** Para clonagem do repositório.

---

## 🚀 Como Clonar e Executar a Aplicação

Siga o passo a passo abaixo para baixar o projeto e executá-lo em sua máquina local via linha de comando:

### 1. Clonar o Repositório
Abra o seu terminal e execute o comando de clonagem (substitua pela URL do seu repositório):

```bash
git clone https://github.com/seu-usuario/StreamingFlix.git
```

### 2. Acessar o Diretório do Projeto
Entre na pasta raiz da solução:

```bash
cd StreamingFlix
```

### 3. Restaurar as Dependências
Restaure os pacotes e dependências dos projetos:

```bash
dotnet restore
```

### 4. Executar a Aplicação (Console)
Para rodar o projeto principal (`StreamingFlix.App`):

```bash
dotnet run --project StreamingFlix.App
```

---

## 🧪 Como Executar os Testes Unitários via CLI

A validação da qualidade das regras de negócio é feita por meio de testes unitários parametrizados (`[Theory]` e `[InlineData]`) no projeto `StreamingFlix.Tests`.

### Execução Simples dos Testes
Para rodar toda a suíte de testes unitários diretamente via CLI, execute na pasta raiz da solução:

```bash
dotnet test
```

### Execução Detalhada
Para acompanhar a execução individual de cada caso de teste no terminal:

```bash
dotnet test --logger "console;verbosity=detailed"
```

---
Anna Vitória Rocha Dias - 325118421  - Dev Backend / Core
Maycon De Oliveira Gomes Batista - 325125878 - QA / Testes Unitários
Karolyne Silva - 32517941 - Documentação e DevOps / Versionamento

*Projeto desenvolvido para a disciplina de Gestão e Qualidade de Software — Prof. Daniel Henrique Matos de Paiva.*