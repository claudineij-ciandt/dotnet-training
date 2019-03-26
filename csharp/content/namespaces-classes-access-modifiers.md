# Namespaces, classes e modificadores de acesso

## Namespaces

* São utilizados para organizar classes, interfaces, enums, etc. da seguinte maneira:

    ```csharp
    System.Console.WriteLine("Hello World!");
    ```

    Onde System é um namespace;
    Onde Console é uma classe contida no namespace System.


* Através da diretiva using adicionamos referências (dependências) em um tipo (classe, interface, etc.). Para isto utilizamos o namespace que contém as classes que precisamos.

    ```csharp
    using System;
    ```

    No trecho de código acima, é adicionada a dependência no namespace System, que organiza e contém uma grande quantidade de classes, estruturas, interfaces, enumerações, delegates do framework .NET. Por exemplo, a classe Console.cs

* Namespaces compõem o nome de uma classe, portanto o nome completo de uma classe contém seu namespace;

    ```csharp
    System.Console.cs
    ```

* Namespaces são úteis para tratar a questão de ambiguidade de nomes, pois classes em contextos diferentes podem ter o mesmo nome;

    ```csharp
    Entities.Produto.cs
    Model.Produto.cs
    Dtos.Produto.cs
    ```

* A boa prática é que os namespaces tenham o mesmo nome dos diretórios da aplicação.

## Classes

Uma classe em C# é um tipo referência. Uma classe é utilizada para definir um tipo composto que contém: campos, propriedades, comportamentos (métodos).

Em C# as classes são declaradas usando a palavra-chave class, seguida por um identificador (nome) exclusivo, conforme mostrado no exemplo a seguir:

Sintaxe:
```csharp
//[access modifier] - [class] - [identifier]
public class Customer
{
   // Fields, properties, methods and events go here...
}
```

Lista de membros de uma classe

Membro | Descrição
--- | ---
Campos | Os campos são variáveis declaradas no escopo da classe. Um campo pode ser um tipo numérico interno ou uma instância de outra classe. Por exemplo, uma classe de calendário pode ter um campo que contém a data atual.
Constantes | As constantes são campos ou propriedades cujo valor é definido em tempo de compilação e não pode ser alterado.
Propriedades | As propriedades são métodos de uma classe acessados como se fossem campos dessa classe. Uma propriedade pode fornecer proteção para um campo de classe para evitar que ele seja alterado sem o conhecimento do objeto.
Métodos | Os métodos definem as ações que uma classe pode executar. Métodos podem usar parâmetros que fornecem dados de entrada e retornar dados de saída por meio de parâmetros. Os métodos também podem retornar um valor diretamente, sem usar um parâmetro.
Eventos | Os eventos fornecem notificações sobre ocorrências a outros objetos, como cliques de botão ou a conclusão bem-sucedida de um método. Eventos são definidos e disparados pelos delegados.
Operadores | Os operadores sobrecarregados são considerados membros de classe. Ao sobrecarregar um operador, ele é definido como um método estático público em uma classe. Os operadores predefinidos (+, -, < e assim por diante) não são considerados membros. Para obter mais informações, consulte Operadores Sobrecarregáveis.
Indexadores | Os indexadores permitem que um objeto seja indexado de maneira semelhante às matrizes.
Construtores | Os construtores são os métodos chamados quando o objeto é criado pela primeira vez.Geralmente, eles são usados para inicializar os dados de um objeto.
Finalizadores | Os finalizadores raramente são usados no C#. Eles são métodos chamados pelo mecanismo de tempo de execução quando o objeto está prestes a ser removido da memória. Geralmente, eles são usados para garantir que recursos que devem ser liberados sejam manipulados corretamente.
Tipos aninhados | Os tipos aninhados são tipos declarados dentro de outro tipo. Geralmente, eles são usados para descrever objetos utilizados somente pelos tipos que os contêm.

Exemplo de uma classe completa:
```csharp
namespace ConsoleApp.src.Entities
{
   public class ProductDetails
   {
       // Membros da classe...
   }
}

// Definição do Namespace
namespace ConsoleApp.src.Entities
{
   // Definição da classe com a visibilidade publica.
   public class Product
   {
       // Definição dos campos
       private string code;
       private string description;
       // Definição de um campo que é uma referência para um outro tipo.
       private ProductDetails productDetails;

       // Definição das propriedades
       public int Code { get; set; }
       public string Description { get; set; }
       public ProductDetails ProductDetails { get; set; }

       // Definição do construtor padrão.
       public Product()
       {
       }

       // Definição do construtor recebendo parametros de inicialização.
       public Product(int code, string description, ProductDetails productDetails)
       {
           this.Code = code;
           this.Description = description;
           this.ProductDetails = productDetails;
       }

       // Definição de um método.
       public void Save(Product product)
       {
       }
   }
}
```

## Operador new

O operador new é utilizado em C# para criar objetos dos tipos em memória, dando para os mesmos uma referência para um endereço de memória.

Para criar um objeto da classe Product.cs, que definimos acima, temos a seguinte sintaxe:

```csharp
// Inicialização de objeto vazio.
var product1 = new Product();

// Inicialização de objeto com valores.
var productDetails = new ProductDetails();

var product2 = new Product(1, "Product 1", productDetails);
```

## Acessando propriedades

```csharp
// Inicialização de objeto vazio.
var product1 = new Product();

// Setando valores nas propriedades
product1.Code = 1;
product1.Description = "Product 1";
product1.ProductDetails = new ProductDetails();

// Acessando valores das propriedades
var text = $"Customer Cristiano bought {product1.Description}";
```

## Modificadores de acesso

Em C# temos os seguintes modificadores de acesso:

Modificador | Descrição
--- | ---
public | Visível de qualquer lugar. Essa é a visibilidade menos restritiva.
protected | Visível somente pela própria classe ou por classes herdam da mesma.
internal | Visível somente no escopo do projeto ou assembly.
protected internal | Visível publicamente no escopo do projeto ou assembly. Visível também por classes que herdam da mesma, dentro ou fora do escopo do projeto.
private | Visível somente internamente. Esta é a visibilidade mais restritiva.
private protected | Visível somente no escopo do projeto ou assembly, desde que acessado internamente pela mesma classe ou por uma classe derivada.

Os modificadores de acesso podem ser usados na definição de todos os membros de uma classe, interface ou estrutura.

**Referências:**
* [C# Classes and Structs](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/classes)