# Injeção de Dependência

>O ASP.NET Core tem uma estrutura de DI (injeção de dependência) interna que torna serviços configurados disponíveis para classes do aplicativo. Também é possível usar frameworks de terceiros que fazem a Injeção de Dependência.

A maneira mais comum de obter uma instância configurada no DI é através do construtor.

```
public class TesteServico
{
    public TesteServico(IRepositorio repositorio)
    {

    }
}
```

### Service Lifetime

O framework de DI provê a possibilidade de escolha de um lifetime apropriado para cada serviço registrado. Os serviços do ASP.NET Core podem ser configurados com os seguintes lifetime:

- Transient

    Uma nova instancia do serviço é criada para cada requisição ao DI. Funciona melhor para serviços leves e stateless.

    ```
    services.AddTransient<IServico, Servico>();
    ```

- Scoped

    Uma nova instancia do serviço é criada para cada requisição a aplicação.

    ```
    services.AddScoped<IServico, Servico>();
    ```

- Singleton

    ```
    services.AddSingleton<IServico, Servico>();
    ```



## Demo

1. Criar uma Api

    ```
    dotnet new webapi -n demo-di
    ```

2. Adicionar uma Classe de Service

    ```
    public class TesteServico
    {
        public TesteServico()
        {

        }

        public string Teste()
        {
            return "Teste DI";
        }
    }
    ```

3. Adicionar um controller

    ```
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly TesteServico servico;

        public TesteController(TesteServico servico)
        {
            this.servico = servico;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return servico.Teste();
        }
    }
    ```

4. Configurar serviço na classe `Startup.cs`, no método `ConfigureServices`

    ```
    services.AddTransient<TesteServico>();
    ```

5. Fazer requisição para API