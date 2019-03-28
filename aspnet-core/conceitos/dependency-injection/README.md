# Injeção de Dependência

O ASP.NET Core tem uma estrutura de DI (injeção de dependência) interna que torna serviços configurados disponíveis para classes do aplicativo. Também é possível usar frameworks de terceiros que fazem a Injeção de Dependência.

A maneira mais comum de obter uma instância configurada no DI é através do construtor.

```
public class TesteServico
{
    public TesteServico(IRepositorio repositorio)
    {
        ...
    }
}
```

Outra possibilidade seria recebendo a instância via parâmetro na action:

```
public class ValuesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromServices]IRepositorio repository)
    {
        ...
    }
}
```


### Service Lifetime

O framework de DI provê a possibilidade de escolha de um lifetime apropriado para cada serviço registrado. Os serviços do ASP.NET Core podem ser configurados com os seguintes lifetimes:

- Transient

    Uma nova instância do serviço é criada para cada requisição ao DI. Funciona melhor para serviços leves e stateless.

    ```csharp
    services.AddTransient<IServico, Servico>();
    ```

    ```csharp
    var instance1 = services.GetService<ServiceTeste>();
    instance1.Add();
    Console.WriteLine($"[Instance 1] Count: {instance1.Count}");
    var instance2 = services.GetService<ServiceTeste>();
    instance2.Increase();
    Console.WriteLine($"[Instance 2] Count: {instance2.Count}");

    // Result
    // [Instance 1] Count: 1
    // [Instance 2] Count: 1
    ```

- Scoped

    Uma nova instância do serviço é criada para cada requisição a aplicação.

    ```csharp
    services.AddScoped<IServico, Servico>();
    ```

    ```csharp
    var instance1 = services.GetService<ServiceTeste>();
    instance1.Increase();
    Console.WriteLine($"[Instance 1] Count: {instance1.Count}");
    var instance2 = services.GetService<ServiceTeste>();
    instance2.Increase();
    Console.WriteLine($"[Instance 2] Count: {instance2.Count}");

    // Result
    // [Instance 1] Count: 1
    // [Instance 2] Count: 2
    ```

- Singleton

    ```
    services.AddSingleton<IServico, Servico>();
    ```