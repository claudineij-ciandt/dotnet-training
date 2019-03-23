# String Builder

Considerando que uma string é imutável, toda vez que uma alteração é feita em uma string, seja executando seus métodos ou concatenando manualmente, uma nova string é alocada na memória.

Em operações realizadas em strings dentro de loops, há um grande risco de degradação de performance por consumo de memória.
Neste caso a boa prática é utilizar o StringBuilder, pois ele tem a capacidade de aumentar o espaço em memória de uma string para comportar novos caracteres.

Os principais métodos que o StringBuilder disponibiliza são:

Método | Descrição
 --- | ---
StringBuilder.Append | Adiciona uma string no final do stringbuilder atual
StringBuilder.AppendLine | Adiciona uma string em uma nova linha do stringbuilder atual
StringBuilder.AppendFormat | Adiciona uma string no final do stringbuilder atual com formatação
StringBuilder.Insert | Insere uma string em um determinado indice do string builder
StringBuilder.Remove | Remove um número especificado de caracteres do StringBuilder atual a partir de um indice.
StringBuilder.Replace | Substitui um caracter por outro dentro do stringbuilder.

Exemplo:
```csharp
StringBuilder sb = new StringBuilder("Hello ",50);
sb.Append("World!!"); sb.AppendLine("Hello C#!");
sb.AppendLine("This is new line.");
Console.WriteLine(sb);
```

Output:
```
Hello World!! Hello C#!.
This is new line.
```

**Referências:**
* [C# - StringBuilder - Examples](https://www.tutorialsteacher.com/csharp/csharp-stringbuilder)
* [Best Practices for Using Strings in .NET](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/best-practices-strings?view=netframework-4.7.2)