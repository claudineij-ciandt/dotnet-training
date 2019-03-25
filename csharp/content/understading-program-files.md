# Entendendo programas e arquivos

## Entendendo um programa em C#

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

## Entendendo arquivos de código, projetos e solução

* Solution: apesar do nome, uma solution não é uma solução ou resposta para um problema. Nada mais é do que um container (pasta) utilizado para agrupar e organizar um ou mais projetos relacionados.

* Project: são aplicações .NET criadas para atender uma necessidade específica. Projetos são baseados nos templates (ConsoleApp, ClassLibrary, Web API, Web, Windows, etc.). Cada projeto tem sua pasta que é um container para os seus arquivos.

**Files:**
* Solution: arquivos de extensão .sln
* Project: arquivos de extensão .csproj
* Classes e outros tipos: arquivos de extensão .cs

**Referências:**
* [Learn about projects and solutions](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-projects-solutions?view=vs-2017)