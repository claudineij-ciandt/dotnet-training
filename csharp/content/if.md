# A instrução de decisão if

É uma estrutura de decisão utilizada para escrever lógica, baseada em uma ou mais expressões booleanas, para definir quais comando(s) devem ou não ser executados.

Exemplos:

```csharp
bool condition = true;

if (condition) //→ Análise da condição.
{
   // Condição verdadeira
   Console.WriteLine("O Valor desta variável é true.");
}
else
{
   // Condição falsa
    Console.WriteLine("O Valor desta variável é false.");
}
```

É possível utilizar a instrução if sem o bloco else:

```csharp
int m = 1;
if (m > 0)
{
   Console.WriteLine("M é um número positivo.");
}
```

É possível utilizar a instrução if ou else com condições aninhadas:

```csharp
if (m > 0)
{
   	if (m == 1)
    {
        Console.WriteLine("M é igual a 1.");
    }
}
else
{
	if (m == -1)
    {
        Console.WriteLine("M é igual a -1.");
    }
}
```

**Referências:**
* [If-Else](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/if-else)
* [Language operators](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/#logical-and-operator)
    * Aqui é possível encontrar a lista completa de operadores (lógicos, aritméticos, etc…)
* [Inline If](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/conditional-operator)
* [Switch Case](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/switch)