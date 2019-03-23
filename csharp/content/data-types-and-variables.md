# Noções sobre tipos de dados e variáveis

_“C# é uma linguagem **fortemente tipada**. Todas as variáveis e constantes têm um tipo, assim como cada expressão que é avaliada como um valor.”_ by Microsoft.

A linguagem C# basicamente trabalha com os dois tipos de dados: **valor** e **referência**.

## Tipo valor

Variáveis deste tipo armazenam diretamente os dados atribuídos a elas. Abaixo a lista dos tipos considerados como valor:

* Tipos simples
    * Integral com sinal: sbyte, short, int,long
        * sbyte: 8 bits, intervalo de -128 a 127
        * short: 16 bits, intervalo de -32.768 a 32.767
        * int : 32 bits, intervalo de -2.147.483.648 a 2.147.483.647
        * long: 64 bits, intervalo de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
    * Integral sem sinal: byte, ushort, uint,ulong
        * byte : 8 bits, intervalo de 0 a 255
        * ushort: 16 bits, intervalo de 0 a 65.535
        * uint : 32 bits, intervalo de 0 a 4.294.967.295
        * ulong : 64 bits, intervalo de 0 a 18.446.744.073.709.551.615
    * Caracteres unicode: char
    * Ponto flutuante IEEE: float, double
        * float : 32 bits, intervalo de 1,5 × 10-45 a 3.4 × 1038, precisão de 7 dígitos
        * double: 64 bits, intervalo de 5,0 × 10-324 a 1,7x 10308, precisão de 15 dígitos
    * Decimal de alta precisão:decimal
        * decimal: 128 bits, intervalo de pelos menos -7,9 × 10-28 a 7,9 × 1028, com precisão de pelo menos 28 dígitos
    * Booleano: bool
* Enum
    * Tipos definidos pelo usuário da seguinte forma: enum E {...}
* Struct
    * Tipos definidos pelo usuário da seguinte forma: struct S {...}
* Nullables
     * Extensões de todos os outros tipos valor que aceita valores nulos.

## Tipo referência

Variáveis deste tipo armazenam endereço de memória de onde os dados estão. Abaixo a lista dos tipos que são considerados como referência:

* Classe
    * Classe base definitiva de todos os outros tipos: object
    * Cadeia de caracteres Unicode: string
    * Tipos definidos pelo usuário da seguinte forma: class C {...}
* Interface
    * Tipos definidos pelo usuário da seguinte forma: interface I {...}
* Matriz
    * Unidimensional e multidimensional, por exemplo, int[] e int[,]
* Delegates
    * Tipos definidos pelo usuário do formulário delegate int D(...)


Referências:

* [C# Types](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/types)
* [Type's Default values](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/default-values-table)
* [Boxing and Unboxing](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/types/boxing-and-unboxing)
* [Table of internal types](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/built-in-types-table)
    * Obs.: Nos submenus da tabelas de referência de tipo, você encontra informações sobre:
        * Tabela de tipos internos
        * Tabela de tipos integrais
        * Tabela de tipos de ponto flutuante
        * Tabela de valores padrão
        * Tabela de tipos de valor
        * Tabela de conversões numéricas implícitas
        * Tabela de conversões numéricas explícitas
        * Tabela de formatação de resultados numéricos