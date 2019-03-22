# Middleware

>A arquitetura do ASP.NET Core é formada por `middlewares`, que são pedaços de código que processam as requisições. 

Cada `middleware` tem a oportunidade de inspecionar, fazer algum trabalho e decidir se a requisição deve continuar no `pipeline` de execução.

um `pipeline` de execução é uma sequencia de `middlewares` que são executados pela ordem em que os `middlewares` foram adicionados ao `pipeline`.


![ASP.NET Core Pipeline de Execução](pipeline.png)

### Configuração do Pipeline

A configuração é feita na class `Startup.cs` no método `Configure`.

```
public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
    app.UseMvc();
}
```

## Demo

1. Criar uma Aplicação

    ```
    dotnet new web -n demo-middleware
    ```

2. Na classe `Startup.cs`, adicionar middleware a requisição

    ```
    // Middleware A
    app.Use(async (context, next) =>
    {
        Console.WriteLine("A (before)");
        await next();
        Console.WriteLine("A (after)");
    });
 
    // Middleware B
    app.Use(async (context, next) =>
    {
        Console.WriteLine("B (before)");
        await next();
    });
    ```

3. Fazer uma requisição HTTP.

    Resultado esperado no Console:
    ```
    A (before)
    B (before)
    A (after)
    ```