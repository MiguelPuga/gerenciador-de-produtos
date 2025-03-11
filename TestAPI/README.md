# Gerenciador de Produtos

Este é um projeto de gerenciar produtos para estudar ASP.NET Core.
Utiliza Domain Driven Design (DDD) e CQRS para modelagem e arquitetura.

- Swagger para documentação da API.
- MediatR
- Entity Framework Core (base de dados in-memory)
- XUnit para testes unitários.

## 📂 Estrutura do Projeto

#### **API/**  
A camada de **API** é responsável por expor os endpoints da API. Nessa camada, você encontrará:
- **Controllers** (para expor os endpoints da API)
- **Swagger** (para documentação da API)

#### **Domain/**  
A camada de domínio contém o modelo de negócio da aplicação.

- **Entidades** (ex.: Product, User, Category)
- **Value Objects** (ex.: Address, Price)
- **Interfaces de Repositórios** (ex.: IRepository)

#### **Infrastructure/**
A camada de infraestrutura implementa as interfaces definidas no domínio e lida com a persistência dos dados.

- **Repositórios** (ex: ProductRepository)
- **Banco de dados in-memory** (Entity Framework)

#### **TestAPI/**
Solução para os testes unitários utilizando XUnit.

## 🚀 Como Compilar e Executar

### 1️⃣ **Pré-requisitos**
Antes de começar, certifique-se de ter instalado:
- [.NET SDK 7.0+](https://dotnet.microsoft.com/download)

### 2️⃣ **Clonar o Repositório**
Se ainda não fez isso, clone o projeto:  
```sh
git clone git@github.com:MiguelPuga/gerenciador-de-produtos.git
```

### 3️⃣ Restaurar Dependências
Execute o seguinte comando para instalar as dependências do projeto:
```sh
dotnet restore
```

### 4️⃣ Compilar o Projeto
Compile a aplicação com:

```sh
dotnet build
```

### 5️⃣ Executar a API
Entre no diretório API:
```sh
cd API
```

Inicie a API com:

```sh
dotnet run
```

Acesse o Swagger em:
➡ https://localhost:7184/swagger


### 6️⃣ Testar a API via Swagger
Após rodar a aplicação, acesse:
🔗 https://localhost:7184/swagger

Lá, você pode testar os endpoints disponíveis.

### 🛠 Tecnologias Utilizadas
- ASP.NET Core
- Entity Framework Core (com banco de dados em memória)
- MediatR
- Swagger (para documentação da API)
