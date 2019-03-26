A linguagem C#, através do seu runtime (CLR) é responsável pelo gerenciamento de memória, isto é, alocação e liberação de memória.

Para a maioria dos objetos criados, o framework .NET cuida da gestão de memória. Porém, caso sejam criados objetos **não gerenciados**, tais como arquivos em memória, conexões com banco de dados, conexões de rede, etc., esses devem ser tratados manualmente para liberar memória.

[25] Gerenciamento de memória

A linguagem C# prove gerenciamento de memória automatizado, para alocação e liberação de memória. Para a maioria dos objetos criados, o framework .net cuida da gestão de memória.
Mas, caso sejam criados objetos não gerenciados, tais como, (Arquivos em memória, conexões com banco de dados, conexões de rede, etc...), esses devem ser tratados manualmente para liberar memória.

Exemplo:

```csharp
using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string path = @"c:\temp\MyTest.txt";
        if (!File.Exists(path))
        {
            // Usando o using para liberar recurso não gerenciado da memória.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
        }
   }
}
```

A instrução using automaticamente fecha e libera o recurso. Ele garante que o método dispose da classe StreamReader seja chamado, liberando desta forma o recurso da memória.

Para detalhes sobre este tema, consulte as referências abaixo:


**Referências:**
* [Memory management](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/memory-management-and-gc)
* [Unmanaged resources](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/unmanaged)
* [Cleaning up unmanaged resources](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/unmanaged)
* [Using statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement)