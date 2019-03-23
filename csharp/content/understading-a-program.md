# Entendendo um programa em C#

```csharp
using System; // 1

namespace ConsoleApp // 2
{
    class Program // 3
    {
        static void Main(string[] args) // 4
        {
            Console.WriteLine("Hello World"); // 5
        }
    }
}
```

1: Adicionando dependência/referência da biblioteca System do framework .NET

2: Definindo o namespace que empacota a classe Program.

3: Definindo a classe Program. Note que o nome da classe é igual nome do arquivo fisíco Program.cs.

4: Definindo o método estático que é invocado toda vez que a aplicação console é executada.

5: Invocando o método estático da classe Console do framework .NET, passando o parâmetro/argumento “Hello World!”, que escreve uma linha no console.
