# Conversão de tipo e Cast

Como a linguagem C# é fortemente tipada em tempo de compilação, depois que uma variável é declarada ela não pode ser declarada novamente com um outro tipo e também não pode ser atribuída com um valor de outro tipo, a não ser que este tipo possa ser convertido implícita e automaticamente.

Exemplo:

Uma string não pode ser convertida implicitamente para um int.

```csharp
int i;  
i = "Hello"; // error CS0029: Cannot implicitly convert type 'string' to 'int'
```

Porém, as vezes precisamos fazer as seguintes operações:
* Copiar o valor de uma variável para outra variável;
* Passar um valor por parâmetro que não é exatamente do tipo esperado. Ex.: Passar um int onde é esperado um double.
* Ou mesmo atribui um objeto de uma classe a uma variável que foi definida com o tipo de uma interface.

Este exemplos acima são chamados de conversão de tipo. No C#, temos os seguintes tipos de conversão:

* **Conversões implícitas:**  Nenhuma sintaxe especial é necessária porque a conversão é de type safe e nenhum dado será perdido. 

    Exemplos:  *incluem conversões de tipos integrais menores para maiores e conversões de classes derivadas para classes base.*
```csharp
    int i = 150300;
    
    double d = i;

    Console.Write(d); 
```

* **Conversões explícitas (casts):**  as conversões explícitas exigem um operador cast. A conversão é necessária quando as informações podem ser perdidas na conversão ou quando a conversão pode não funcionar por outros motivos.

    Exemplos típicos: *incluem a conversão numérica para um tipo que tem menos precisão ou um intervalo menor e a conversão de uma instância de classe base para uma classe derivada.*
```csharp
    double d= 150300,457689 ;  
    int i = (int)d;
    Console.Write(i);
```
* **Conversões definidas pelo usuário:** São conversões customizadas desenvolvidos para conversão de um tipo para outro.
    
    Exemplos: via automapper, via classes de mapeamento customizadas, que fazem o famoso De Para.

* **Conversões com classes utilitárias:**  São conversões feitas por classes do próprio framework .
Exemplos: 

```csharp
    System.Convert.ToDouble("1");

    DateTime date;
    System.DateTime.TryParse("01/01/2019", out date);

    System.DateTime.Parse("01/01/2019");

    Int32.Parse("10");
````

**Obs:** Caso o valor informado não seja suportado para conversão, um erro de exceção de argumento ocorrerá. 

**Desafio:** Qual o output do comando abaixo?
```csharp
Console.Write($"1/2 é igual a: {1/2}");
````
