# Coleções

## Array e Matriz

Exemplos:
```csharp
// Declaração array vazio de array unidimensional de 5 posições
int[] array1 = new int[5];

// Declaração e inicialização de array unidimensional com elementos.
int[] array2 = new int[] { 1, 3, 5, 7, 9 };

// Sintaxe alternativa.
int[] array3 = { 1, 2, 3, 4, 5, 6 };

// Declaração de array multidimensional
int[,] multiDimensionalArray1 = new int[2, 3];

// Declaração de array multidimensional com inicialização
int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

// Declaração de matriz> Obs.: Coluna e Linha
int[][] jaggedArray = new int[6][];

// Set the values of the first array in the jagged array structure
jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
```

## Coleções e estruturas de dados


Eu quero… | Opções de coleção genérica | Opções de coleção não genérica | Opções de coleção thread-safe ou imutável
--- | --- | --- | ---
Armazenar itens como pares chave/valor para consulta rápida por chave | [Dictionary<TKey,TValue>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.dictionary-2) | [Hashtable](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.hashtable) | [ConcurrentDictionary<TKey,TValue>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.concurrent.concurrentdictionary-2), [ReadOnlyDictionary<TKey,TValue>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.objectmodel.readonlydictionary-2), [ImmutableDictionary<TKey,TValue>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.immutable.immutabledictionary-2)
Itens de acesso por índice | [List<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1) | [Array](https://docs.microsoft.com/pt-br/dotnet/api/system.array), [ArrayList](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.arraylist) | [ImmutableList<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.immutable.immutablelist-1), [ImmutableArray](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.immutable.immutablearray)
Usar itens primeiro a entrar, primeiro a sair (PEPS) | [Queue<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.queue-1) | [Queue](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.queue) | [ConcurrentQueue<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.concurrent.concurrentqueue-1), [ImmutableQueue<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.immutable.immutablequeue-1)
Usar dados último a entrar, primeiro a sair (UEPS) | [Stack<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.stack-1) | [Stack](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.stack) | [ConcurrentStack<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.concurrent.concurrentstack-1), [ImmutableStack<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.immutable.immutablestack-1)
Acessar itens em sequência | [LinkedList<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.linkedlist-1) | |
Receber notificações quando itens forem removidos da coleção ou adicionados a ela (implementa [INotifyPropertyChanged](https://docs.microsoft.com/pt-br/dotnet/api/system.componentmodel.inotifypropertychanged?view=netframework-4.7.2) e [INotifyCollectionChanged](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.specialized.inotifycollectionchanged)) |[ObservableCollection<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.objectmodel.observablecollection-1)
Uma coleção ordenada | [SortedList<TKey,TValue>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.sortedlist-2) | [SortedList](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.sortedlist) | [ImmutableSortedDictionary<TKey,TValue>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.immutable.immutablesorteddictionary-2), [ImmutableSortedSet<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.immutable.immutablesortedset-1)
Coleção que não permite itens duplicados | [HashSet<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.hashset-1) | [SortedSet<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.sortedset-1) | [ImmutableHashSet<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.immutable.immutablehashset-1), [ImmutableSortedSet<T>](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.immutable.immutablesortedset-1)

**Referências:**
* [Arrays](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/arrays/index)
* [Colections and data structure](https://docs.microsoft.com/pt-br/dotnet/standard/collections/)
