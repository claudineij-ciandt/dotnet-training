# ASP.NET Core APIs
ASP.NET Core provê um framework que permite a criação de APIs e Web Apps. Este framework é chamado MVC(*Model-View-Controller*).

![ASP.NET Core API](architecture.png)

#### Controller

Os **controllers** são classes responsáveis por lidar com a interação e responder a requisições dos usuários.

Por convenção, as classes **controllers** ficam dentro da pasta `Controller`, na raiz do projeto web e as classes controllers devem ter no final de seu nome a anotação `Controller`. Por exemplo: `TesteController.cs`

Quando criado um controller para atender uma requisição, o **controller** deve conter a annotation `[ApiController]`. O MVC também provê a classe base `ControllerBase` com várias opções de métodos e propriedades que auxiliam no tratamento da request.

```
[Route("api/[controller]")]
[ApiController]
public class TesteController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
```

#### Routing

*Routing* no ASP.NET Core MVC é um mecanismo que faz o mapeamento entre o **controller** e a action method com a requisição que eles atendem.

Existem algumas formas de configurar os mapeamentos para as rotas, porém a mais comum é o **attribute routing**. Também podemos decorar as actions com annotations `[HttpGet]`, `[HttpPost]`, `[HttpPut]` e `[HttpDelete]` para sinalizar qual operação REST ela responde.

- Attribute routing controller

    Nesse exemplo, temos apenas o mapeamento na classe controller. O trecho `[controller]` será substituído pelo nome do controller. Também é possível especificar um valor diferente do nome do controller.

    O mapeamento abaixo atende a rota `/api/teste`.
    ```
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
    ```

- Attribute routing na action

    Podemos adicionar, na action, uma configuração via annotation. No exemplo abaixo, a action atende a rota `/api/teste/lista`. Note que parte da configuração é feita no controller e essa configuração se estende à todas as actions dentro do controller.
    ```
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        [HttpGet("lista")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
    ```

- Attribute routing action com parâmetros na URL

    Neste exemplo, usamos o trecho `{id}` para sinalizar que um parâmetro será passado via URL e será populado na propriedade id.
    ```
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(id);
        }
    }
    ```
#### Action
Actions são métodos dentro dos controllers que executam o processamento da requisição. Elas podem tanto não retornar nenhum valor, quanto retornar um valor ou um status. Os exemplos abaixo mostram alguns tipos de retorno que uma action pode ter.

- Não retorna nenhum valor
    ```
    [HttpDelete("{id}")]
    public void Get(int id)
    {
        DoWork(id);
    }
    ```

- Retornando um objeto
    ```
    [HttpGet("{id}")]
    public TesteModel Get(int id)
    {
        return repository.Get(id);
    }
    ```

- Retornando um objeto com HTTP status code
    ```
    [HttpGet]
    public IActionResult Get()
    {
        var modelList = repository.Get();
        return Ok(modelList);
    }
    ```
    ```
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var modelList = repository.Get(id);
        if(modelList == null)
        {
            return NotFound();
        }

        return Ok(modelList);
    }
    ```

#### Model Binder
>Model binding in ASP.NET Core MVC maps data from HTTP requests to action method parameters. The parameters may be simple types such as strings, integers, or floats, or they may be complex types.

- Tipos primitivos como parte da URL
    ```
    [HttpGet("{id}/{name}")]
    public TesteModel Get(int id, string name)
    {
        return repository.Get(id);
    }
    ```
- Tipos primitivos como parte da query string `?`
    ```
    [HttpGet]
    public TesteModel Get([FromQuery]int id)
    {
        return repository.Get(id);
    }
    ```
- Tipos complexos como parte da query string `?`
    ```
    [HttpGet]
    public TesteModel Get([FromQuery]ProductModel model)
    {
        return repository.Get(id);
    }
    ```
- Model binding no corpo da requisição
    ```
    [HttpPost]
    public TesteModel Get([FromBody]int id, [FromBody]ProductModel model)
    {
        return repository.Get(id);
    }
    ```