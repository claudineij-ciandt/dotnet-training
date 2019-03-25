# Exceções

O C# fornece suporte interno para tratamento de situações anormais, conhecidas como exceções, que podem ocorrer durante a execução do programa. Essas exceções são tratadas pelo código que está fora do fluxo de controle normal.

Pode-se lançar exceções programaticamente utilizando a instrução throw. Toda exceção lançada por um throw deve derivar da classe base System.Exception:

```csharp
if (index < 0 || index >= numbers.Length) {
   throw new IndexOutOfRangeException();
}
```

O tratamento de exceções é realizado pelo bloco try-catch-finally.

O try é utilizado para delimitar um bloco de código que pode causar uma exceção, enquanto o catch contém o tratamento de um tipo de exceção. O bloco catch é executado apenas quando é lançada uma exceção do tipo especificado:

```csharp
try
{
   OpenFile();
}

catch (FileNotFoundException e)
{
   // FileNotFoundExceptions are handled here.
}
```

Quando um mesmo bloco pode gerar diferentes exceções com diferentes tratamentos, pode-se utilizar um try com múltiplos blocos catch, e o tratamento será feito pelo primeiro catch correspondente. A prática recomendada é tratar as exceções das mais específicas para as mais gerais:

```csharp
try
{
   OpenFile();
}

catch (FileNotFoundException e)
{
   // FileNotFoundExceptions are handled here.
}
catch (IOException e)
{
   // IOExceptions are handled here.
}
```

Por fim, o finally contém um bloco de instruções que são sempre executadas, independente se a execução entrar num catch ou não.
O finally é geralmente utilizado para garantir a liberação de recursos (não-gerenciados) alocados.

```csharp
void ReadFile(int index)
{
   System.IO.StreamReader file = new System.IO.StreamReader(@"c:\my-file.txt");
   char[] buffer = new char[10];

   try
   {
       file.ReadBlock(buffer, index, buffer.Length);
   }
   catch (System.IO.IOException)
   {
       Console.WriteLine("Error reading from file");
   }

   finally
   {
       file.Close();
   }
}
```

**Referências:**
* [Exception handling statements](https://docs.microsoft.com/en-US/dotnet/csharp/language-reference/keywords/exception-handling-statements)