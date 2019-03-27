# [Non-Functional Task] Resolver débitos técnicos

## Visão geral

Resolver os débitos técnicos gerados pelas estórias anteriores. São eles:
* Na listagem de categorias, exibir a **data de criação** no formato **dd/MM/yyyy**.
* Como o formato da data pode variar de acordo com o local onde o sistema será instalado, este formato deve ser uma propriedade de **configuração**.
* O tratamento de exceções, então contido na API, deve ser movido para um novo **middleware**.

## Middleware

O código, neste momento, está capturando exceções na API e retornando um HTTP status code correspondente, semelhante ao código abaixo:
```csharp
[HttpGet]
public IActionResult Get()
{
    try
    {
        service.GetResult();
        return Ok();
    }
    catch(BusinessException)
    {
        return BadRequest();
    }
}
```

O middleware deve ser desenvolvido de forma que este mesmo comportamento se mantenha, porém sem que haja qualquer try-catch na API:
```csharp
[HttpGet]
public IActionResult Get()
{
    service.GetResult();
    return Ok();
}
```

Para a criação de middlewares, consulte o [tópico sobre middleware](https://github.com/claudineij-ciandt/dotnet-training/blob/master/aspnet-core/conceitos/middleware/README.md) e [seu lab](https://github.com/claudineij-ciandt/dotnet-training/blob/master/aspnet-core/labs/lab3-middleware/README.md).

## Configuração

Se necessário, acesse também o [tópico sobre configuração](https://github.com/claudineij-ciandt/dotnet-training/blob/master/aspnet-core/conceitos/configuration/README.md).