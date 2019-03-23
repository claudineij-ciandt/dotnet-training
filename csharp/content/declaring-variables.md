# Declarando variáveis

Existem duas formas para declarar variáveis.

## Implícita

Use este tipo quando o tipo da variável for óbvio de se inferir pelo valor do lado direito da atribuição.

Exemplos:

```csharp
var var1 = "Claramente este valor é uma string";
var var2 = 27;
var var3 = Convert.ToInt32(Console.ReadLine());
var  inicio = DateTime.Now();
```

## Explícita

Use este tipo quando o tipo não for aparente ou óbvio no lado direito da declaração.

Exemplo:

```csharp
int var4 = ExampleClass.ResultSoFar();
```

**Referências:**
* [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)