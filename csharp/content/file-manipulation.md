# File manipulation

## Classe File.cs

Provê métodos estáticos para criar, copiar, excluir, mover e abrir arquivos para leitura ou escrita.

Exemplo:
```csharp
using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string path = @"c:\temp\MyTest.txt";

        // Verificando se o arquivo existe.
        if (!File.Exists(path))
        {
            // Criando um arquivo para escrita.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
        }

        // Abrindo o arquivo para leitura.
        using (StreamReader sr = File.OpenText(path))
        {
            string s;

		    // Lendo linha a linha do arquivo, até o seu final.
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
```

### Classe Path.cs

Provê metódos para:
* Transformar uma string em um path (caminho) válido
* Extrair informações de caminho e diretório a partir de uma string

Exemplos:
```csharp
var drive = "c:";
var pasta = "test";
var filename = "myfile.json";
var path =  Path.Combine(drive, pasta, filename);

Console.WriteLine($"Path combinado:{path}");

Console.WriteLine($"File extension: {Path.GetExtension(path)}");

Console.WriteLine($"File name sem extensão: {Path.GetFileName(path)}");

Console.WriteLine($"Root path: {Path.GetPathRoot(path)}");

Como ler o conteúdo de arquivo:

class ReadFromFile
{
   static void Main()
   {
       // Lendo todo o conteúdo do arquivo de uma só vez.
       string text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
       System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

       // Lendo o conteúdo do arquivo e gerando uma array de suas linhas.
       string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");

       // Lendo linha a linha do arquivo e escrevendo no console.
       foreach (string line in lines)
       {
         Console.WriteLine("\t" + line);
       }

       Console.WriteLine("Press any key to exit.");
       System.Console.ReadKey();
   }
}
```

## Como criar e escrever conteúdo em um arquivo

```csharp
class WriteTextFile
{
    static void Main()
    {
        // ########################################################################
        // Exemplo 1: Escrevendo linhas a partir de uma array de linhas.
        // ########################################################################
        string[] lines = { "First line", "Second line", "Third line" };

        //Obs.: Com esse método não é necessário, fechar liberar ou fechar o arquivo criado.
        System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);

	    // ########################################################################
        // Example #2: Utilizando uma string para gerar o conteúdo de um arquivo
        // ########################################################################
        string text = "A class is the most powerful data type in C#. Like a structure, " +
                       "a class defines the data and behavior of the data type. ";

        //Obs.: Com esse método não é necessário, fechar liberar ou fechar o arquivo criado.
        System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);

        // ########################################################################
        // Example #3: Escrevendo linha a linha no arquivo.
        // ########################################################################
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
        {
            foreach (string line in lines)
            {
                // Lógica
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
            }
        }

        // ########################################################################
        // Example #4: Adicionando uma linha no final do arquivo.
        // ########################################################################

	    // O último parâmetro do construtor da classe string arquivo, identifica que é uma operação de append content.
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt", true))
        {
            file.WriteLine("Fourth line");
        }
    }
}
```

Possíveis exceções:
    * System.ArgumentException
    * System.ArgumentNullException
    * System.IO.DirectoryNotFoundException
    * System.IO.FileNotFoundException
    * System.IO.IOException
    * System.IO.PathTooLongException
    * System.NotSupportedException
    * System.Security.SecurityException
    * System.UnauthorizedAccessException


**Referências:**
* [File system](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/)
* [How to write to a file](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file)
* [How to read from a file](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file)