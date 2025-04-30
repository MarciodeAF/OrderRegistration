# OrderRegistration

# Clean Architecture - .NET Core Web API (CRUD de Pedidos)

Este projeto demonstra a implementação da Clean Architecture em uma aplicação ASP.NET Core Web API (.NET 6), realizando operações CRUD sobre a entidade **Pedido** com integração ao banco de dados SQL Server.

---

## 🔧 Tecnologias Utilizadas

- .NET 6 (ASP.NET Core Web API)
- Entity Framework Core
- SQL Server
- Swagger (Swashbuckle)
- AutoMapper
- UseInMemoryDatabase

---

## 📐 Arquitetura

A estrutura segue os princípios da **Clean Architecture**, separando responsabilidades em camadas distintas:

|── Domain/ → Entidades e interfaces de repositórios 
├── Application/ → Casos de uso (UseCases), DTOs e interfaces 
├── Infrastructure/ → Implementações de repositórios, DbContext, Migrations 
├── API/ → Controllers, injeção de dependência, configuração


- **Domain**: regras de negócio puras (Enterprise Business Rules)
- **Application**: lógica de aplicação (casos de uso)
- **Infrastructure**: acesso a dados (implementações de repositórios)
- **API**: camada de entrega (Controllers e serviços externos)

---

## ⚙️ Funcionalidades da API

Operações CRUD para o recurso **Pedidos**:

- `GET /api/pedidos` → Listar todos os pedidos
- `GET /api/pedidos/{id}` → Obter um pedido por ID
- `POST /api/pedidos` → Criar novo pedido
- `PUT /api/pedidos/{id}` → Atualizar um pedido existente
- `DELETE /api/pedidos/{id}` → Remover um pedido

---

## 🔄 Fluxo de Requisição

1. Controller recebe a requisição
2. Controller chama o caso de uso da camada `Application`
3. Caso de uso utiliza o repositório (interface) definido na camada `Domain`
4. Repositório é implementado na `Infrastructure` (EF Core ou Dapper)
5. Resposta é devolvida ao cliente via Controller

---

## 📄 Swagger

A documentação da API está disponível via Swagger:

https://localhost:{porta}/swagger


---

## 🧱 Padrões e Boas Práticas

- SOLID Principles
- Clean Code
- Validação com FluentValidation
- AutoMapper para conversão entre entidades e DTOs
- Injeção de Dependência via `Program.cs`
- Configuração centralizada por meio do `appsettings.json`

---

## 📦 Como Executar

1. Clone o repositório
2. Configure o `appsettings.json` com sua connection string do SQL Server
3. Execute as migrations:
   ```bash
   dotnet ef database update

## 📚 Referências

Clean Architecture — Uncle Bob
Microsoft Docs — Clean Architecture in .NET
Repositórios base: Jason Taylor, Jean Gatto


## ✅ Requisitos Atendidos

✅ Clean Architecture aplicada
✅ CRUD funcional de Pedidos
✅ Documentação via Swagger
✅ EF Core como ORM
✅ Projeto modular, testável e escalável
✅ Projeto UseInMemoryDatabase
