# Métodos de extensão

Em C# é possível adicionar comportamento em uma classe sem alterá-la. Isto é possível através dos métodos de extensão.

Observação: Muito útil para adicionar comportamento em classes de bibliotecas externas, onde você não tenha posse do código.

**Sintaxe:**
```csharp
namespace ConsoleApp.src.Extensions
{
   public static class ProductExtension
   {
       public static void AddTag(this Product product)
       {
           // implementação...
       }
   }
}
```

**Restrição:** Métodos de extensão só podem ser implementados em classes estáticas e não genéricas.

**Utilização:** Para utilizar um método de extensão em uma classe, adicione uma diretiva using com o namespace onde foi criado o método de extensão.

Exemplo:
```csharp
using ConsoleApp.src.Entities;
using ConsoleApp.src.Extensions;

namespace ConsoleApp
{
   class Program
   {
       static void Main(string[] args)
       {
           // Inicialização de objeto vazio.
           var product1 = new Product();
           product1.AddTag();
       }
   }
}
```