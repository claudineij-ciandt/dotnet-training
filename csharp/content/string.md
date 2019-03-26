# String

## Principais características

* Uma string é um array de caracteres;
    ```csharp
    char[] letters = { 'A', 'B', 'C' };
    string alphabet = new string(letters);
    ```

* O tipo string do C# é um alias para o tipo System.String do .NET Framework;

* Uma string é **imutável**;
    ```csharp
    var s1 = "minusculo";
    s1.ToUpper();
    ```

    Resultado:
    ```
    Retorno do método s1.ToUpper(): MINUSCULO
    Valor da variável s1: minusculo
    ```

## Propriedade pública da classe string

* Length
    ```csharp
    s1.Length;
    ```

## Métodos para manipulação de strings

A classe string provê uma série de métodos para manipulação, tais como: Substring, Split, Concat, ToUpper, ToLower, Trim, etc.

## Métodos mais comuns para concatenação de strings:

* Operador +
    ```csharp
    var id = 1;
    var text1 = "User id" + id;
    ````

* Método String.Concat
 ```csharp
    var text2 = string.Concat("User id: ", id);
````
* Interpolação de string
```csharp
    var text3= $"User id: {id}"; 
````
* String builder

    **Obs.:** *Será abordado no próximo tópico.*

**Referências:**
* [String class](https://docs.microsoft.com/pt-br/dotnet/api/system.string?view=netframework-4.7.2)
* [Basic string operations](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/basic-string-operations)
* [String Methods](https://docs.microsoft.com/pt-br/dotnet/api/system.string?view=netframework-4.7.2#m%C3%A9todos)

* [How to concatenate strings](https://docs.microsoft.com/en-us/dotnet/csharp/how-to/concatenate-multiple-strings)
