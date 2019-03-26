# Configuração
>An app’s config is everything that is likely to vary between deploys (staging, production, developer environments, etc)

O ASP.NET Core suporta vários métodos de configurações. As configurações são salvas em forma de chave/valor e podem ser lidas em tempo de execução. Também é permitida a configuração de mais de um provider.

#### Providers de configurações

- Argumentos de linha de comando;
- Providers Customizados (instalado ou criado)
- Diretório de arquivos
- Variáveis de ambiente
- Objetos .NET In-memory
- Arquivos de Configuração(JSON, XML)

## Demo

1. Criar uma aplicação Api
```
dotnet new webapi -n demo-configuration
```

2. No arquivo `appsettings.json`, criar uma chave de configuração

```
"ConfiguracaoDemo": "Configuracao Teste"
```

3. Ler configuração na classe de inicialização(`Startup.cs`)
```
Console.WriteLine(Configuration["ConfiguracaoDemo"]);
```

#### Ler configuração via DI

4. Adicionar configuração ao DI
```
services.AddSingleton<IConfiguration>(Configuration);
```

5. Ler configuração no controller
```
[Route("api/[controller]")]
[ApiController]
public class ConfiguracaoController : ControllerBase
{
    private readonly IConfiguration configuration;

    public ConfiguracaoController(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    [HttpGet]
    public ActionResult<string> DatabaseNameGet()
    {
        return configuration["ConfiguracaoDemo"];
    }
}
```

#### Bind da configuração com Model

6. Adicionar configuração ao arquivo `appsettings.json`
```
"ConnectionString": {
    "DefaultConnection": "localhost",
    "DatabaseName": "demo"
  }
```

7. Criar class model
```
public class ConnectionString   
{
    public string DefaultConnection { get; set; }  
    public string DatabaseName { get; set; }  
}
```

8. Adicionar bind da configuração
```
services.Configure<ConnectionString>(Configuration.GetSection("ConnectionString"));
```

9. Ler configuração via DI
```
[Route("api/[controller]")]
[ApiController]
public class ConfiguracaoController : ControllerBase
{
    private readonly IOptions<ConnectionString> connection;

    public ConfiguracaoController(IOptions<ConnectionString> connection)
    {
        this.connection = connection;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(connection);
    }
}
``` 