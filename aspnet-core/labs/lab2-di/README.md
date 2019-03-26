# Hands-on Lab #2 - Dependency Injection

## Visão Geral
Criar uma API que retorna os dados do repository

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
    dotnet new webapi -n lab2
    ```

2. Adicionar uma classe e uma interface de Service

```csharp
public interface ITesteServico
{
    string Teste();
}

public class TesteServico : ITesteServico
{
    public string Teste()
    {
        return "Teste DI";
    }
}
```

3. Criar um controller que para chamada do serviço via construtor

4. Criar uma action para chamada do serviço via parâmetro do método