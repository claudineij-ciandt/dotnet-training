# LINQ

O LINQ é um conjunto de tecnologias que permite a integração de recursos de querying na própria linguagem. Alguns destes recursos são: filtros, ordenações, agrupamentos e projeções. O LINQ oferece uma sintaxe compacta, expressiva e inteligente para manipular dados.

O LINQ pode ser utilizado para manipular dados não somente em coleções .NET, mas também em bancos de dados e documentos XML/JSON, por exemplo. Ao utilizar o LINQ para realizar consultas em um banco de dados (desde que o driver suporte), obtém-se o benefícios oferecidos pela linguagem, como type-checking e IntelliSense, diferentemente de quando há queries representadas em strings.

O LINQ pode ser utilizado de 2 maneiras. A primeira é através da sintaxe de query, embutida na própria linguagem:
```csharp
var linqExperts = from p in programmers
                  where p.IsNewToLINQ
                  select new LINQExpert(p);
```

A segunda é através da sintaxe fluent, utilizando a IEnumerable<> API:
```csharp
var linqExperts = programmers.Where(p => p.IsNewToLINQ)
                             .Select(p => new LINQExpert(p));
```

O LINQ possui uma API bastante extensa. Uma referência completa pode ser consultada aqui. Alguns dos principais métodos do LINQ são:

Método | Descrição
--- | ---
Count | Retorna o número de elementos de uma coleção.
Distinct | Retorna os elementos distintos de uma coleção.
First | Retorna o primeiro elemento de uma coleção.
GroupBy | Agrupa elementos de uma coleção.
Last | Retorna o último elemento de uma coleção.
OrderBy | Ordena os elementos de uma coleção em ordem ascendente.
OrderByDescending | Ordena os elementos de uma coleção em ordem descendente.
Select | Projeta cada elemento de uma coleção numa nova coleção.
Sum | Retorna a soma de uma coleção de valores
Union | Retorna a união de duas coleções.
Where | Filtra uma coleção baseado em um critério.

**Referências:**
* [Using LINQ](https://docs.microsoft.com/en-us/dotnet/standard/using-linq)
* [Language Integrated Query](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/index)
* [101 LINQ examples](https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b)
