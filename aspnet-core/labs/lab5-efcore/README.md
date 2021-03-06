# Hands-on Lab #5 - Entity Framework

## Visão Geral
Criar uma API com acesso a dados em banco dados in memory usando o Entity Framework

## Pré-Requisitos
- Visual Studio ou VS Code
- .NET Core SDK instalado
- Postman ou similar

### Passos

1. Criar uma aplicação web
    ```
    dotnet new webapi -n lab5
    ```
    
2. Adicionar pacote entity framework
```
cd lab5
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

3. Adicionar a seguinte classe que representa uma entidade

```csharp
public class Produto
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public decimal Valor { get; set; }
}
```

4. Adicionar a seguinte classe que representa o Contexto

```csharp
public class Context : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    public Context(DbContextOptions options)
        : base(options)
    {
    }
}
```

5. Registrar o contexto no DI
```csharp
services.AddDbContext<Contexto>(c => c.UseInMemoryDatabase(databaseName: "demo"));
```

6. Criar um controller com método `[HttpPost]` para criar registros

7. Criar um controller com método `[HttpGet]` para retornar todos os registros

8. Criar um controller com método `[HttpGet]` para retornar registro pelo id
