# Interfaces e classes abstratas

## Interfaces

Uma interface, no paradigma da orientação a objetos, é um tipo de classe que contém apenas as assinaturas de métodos, propriedades, eventos e indexadores, sem implementação alguma.

Sintaxe:
```csharp
using ConsoleApp.src.Entities;

namespace ConsoleApp.src.Interfaces
{
   // Definindo a interface
   public interface IProduct
   {
       // Definindo propriedades
       string Code { get; set; }
       string Description { get; set; }
       ProductDetails ProductDetails { get; set; }

       // Definindo método
       void Save(Product product);
   }
}
```

A implementação dos membros de uma interface é feita por uma:
* Classe concreta; ou
* Estrutura.

Exemplo:
```csharp
public class Product : IProduct
```

Uma interface pode ser utilizada para definir um tipo de campo, propriedade, variável ou parâmetro de método.

Exemplo:
```csharp
IProduct product1 = new Product();
```

**Convenção de nome:** no C#, é recomendado que todo nome de interface comece com I maiúsculo. Exemplos: IProductService, ICustumerService.

## Clases abstratas

Existe um outro tipo de classe em C#, chamada classe abstrata, que é muito parecido com interface.
A única diferença é que, em uma classe abstrata, é possível ter implementação nos membros definidos. Para maiores detalhes, veja as referências abaixo.

Obs.: Não é possível criar instâncias de classes abstratas.

**Referências:**
* [C# Interfaces](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/interfaces/)
* [Abstract and sealed classes](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members)
