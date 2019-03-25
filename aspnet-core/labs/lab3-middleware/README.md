# Hands-on Lab #3 - Criar um Middleware

## Visão Geral
Criar um middleware para capturar exceptions não tratadas pela aplicação e retornar uma mensagem e um HTTP status code padrão.

## Pré-Requisito
- Visual Studio ou VS Code
- .NET Framework instalado
- Postman ou similar

### Requisitos

- Criar um controller fazendo throw de exception de tempos em tempos 
- Capturar a exception dentro de um middleware
- Retornar error 500

### Passos

1. Criar uma aplicação web
    ```
    dotnet new webapi -n lab3
    ```

2. Adicionar controller para simular de tempos em tempos uma Exception
```
[Route("api/[controller]")]
[ApiController]
public class TesteController : ControllerBase
{
    private static int count = 0;

    [HttpGet]
    public IActionResult Get()
    {
        count++;

        if(count % 2 == 0)
        {
            return Ok();
        }
        else 
        {
            throw new Exception();
        }
    }
}
```

3. Criar um middleware que faça um `try/catch` do método `next();`

4. No `catch`, usar o trecho de código abaixo para mudar o HTTP status code
```
context.Response.ContentType = "text/plain";
context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
await context.Response.WriteAsync("Oops! Ocorreu um erro.");
```

5. Fazer requisição ao endpoint e validar se quando tem uma exception, retorna mensagem "Oops! Ocorreu um erro."