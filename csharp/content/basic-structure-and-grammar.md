# Estrutura e gramática básica

## Final de linha

Exemplo:
```csharp
Console.WriteLine("------------------------------------");
```

## Comentário

Exemplo em linha:
```csharp
// Console.WriteLine("------------------------------------");
```

Exemplo em bloco:
```csharp
/* Console.WriteLine("------------------------------------");
    Console.WriteLine("Texto formatado:");
    Console.WriteLine("------------------------------------");
    Console.WriteLine(sbuilder.ToString());
*/
```

## Bloco de código e delimitador de escopo

Exemplo:
```csharp
{
    //Código
}
```

## Caracteres especiais

**@**: Utilizado para definir um identificador fazendo distinção das palavras chaves da linguagem.

Exemplo:
```csharp
var @class = new Type();
```

Obs.: class é uma palavra reservada da linguagem. Sem o caractere @, não poderia ser usada para nomear uma variável.

**$**: Utilizado para fazer interpolação (inserir, concatenar e formatar conteúdo) em strings.

```csharp
var number = 1;
$"Numero: {number}";
```

Obs.: Especificação completa nas referências abaixo.

**Referências:**
* [C# Lexical structure](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/lexical-structure#syntactic-grammar)
* [Character scape sequence](https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=vs-2017)
* [String interpolation](https://docs.microsoft.com/pt-br/dotnet/csharp/tutorials/string-interpolation)
* [Naming Conventions](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/inside-a-program/identifier-names#naming-conventions)

