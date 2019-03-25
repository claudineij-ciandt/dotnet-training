A linguagem C#, através do seu runtime (CLR) é responsável pelo gerenciamento de memória, isto é, alocação e liberação de memória.

Para a maioria dos objetos criados, o framework .NET cuida da gestão de memória. Porém, caso sejam criados objetos **não gerenciados**, tais como arquivos em memória, conexões com banco de dados, conexões de rede, etc., esses devem ser tratados manualmente para liberar memória.

**Referências:**
* [Memory management](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/memory-management-and-gc)
* [Unmanaged resources](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/unmanaged)