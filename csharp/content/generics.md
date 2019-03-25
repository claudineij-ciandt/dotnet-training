# Generics

## Classes e métodos genéricos

Veja exemplos de utilização de generics abaixo.

Definindo classe genérica:
```csharp
public class MinhaClasseGenerica<T>
{
    public T Field;
}
```

Utilizando a classe genérica:
```csharp
public static void Main()
{
    MinhaClasseGenerica<string> g = new MinhaClasseGenerica<string>();
    g.Field = "A string";
    Console.WriteLine("Generic.Field = \"{0}\"", g.Field);
}
```

Definindo método genérico:
```csharp
public class MinhaClasseGenerica<T>
{
    private T Field;

    public void Add(T arg)
    {
        Field = arg;
    }

    public T Get()
    {
        return Field;
    }
}
```

Utilizando o método genérico:
```csharp
public static void Main()
{
    MinhaClasseGenerica<string> g = new MinhaClasseGenerica<string>();
    g.Add("A string");
    Console.WriteLine("Generic.Field = \"{0}\"", g.Get());
}
```

## Restrições do tipo T

O generics provê um recurso (constraints) para restringir:

Restrição | Descrição
--- | ---
where T : struct | Somente tipos valor, não aceita tipos nulos.
where T : class | O argumento T deve ser um tipo de referência. Essa restrição se aplica também a qualquer classe, interface, delegate ou tipo de matriz.
where T : unmanaged | O argumento T não deve ser um tipo de referência e não deve conter nenhum membro de tipo de referência em nenhum nível de aninhamento.
where T : new() | O argumento T deve ter um construtor público sem parâmetros. Quando usado em conjunto com outras restrições, a restrição new() deve ser a última a ser especificada.
where T : <nome de classe base> | O argumento  T deve ser ou derivar da classe base especificada.
where T : <nome da interface> | O argumento T deve ser ou implementar a interface especificada. Várias restrições de interface podem ser especificadas. A interface de restrição também pode ser genérica.
where T : U | O argumento T deve ser ou derivar do argumento fornecido para U.

Exemplo de classe com constraint:
```csharp
public class MinhaClasseGenerica<T> where T : struct
{
    public T Field;
}

Utilizando a classe com constraint:
public static void Main()
{
   // Compile-time error:
   MinhaClasseGenerica<string> g = new MinhaClasseGenerica<string>();

   // OK:
   MinhaClasseGenerica<int> g = new MinhaClasseGenerica<int>();
}
```

**Referências:**
* [System.Generics](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic?view=netframework-4.7.2)
* [Advanced aspects - Covariance and contravariance](https://docs.microsoft.com/pt-br/dotnet/standard/generics/covariance-and-contravariance)