# Estrutura de repetição for

Executa um comando ou bloco de comandos enquanto uma condição iterativa é verdade. Normalmente utilizamos essa estrutura de repetição para execução de uma sequência conhecida.

Exemplos:
```csharp
for (inicialização; condição; iterador)
    Corpo
```

Em qualquer parte do (body) corpo da instrução for, podemos:
* Parar/sair a execução dos comandos e sair do for, utilizando a instrução [break](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/break);
* Continuar, indo para a próxima iteração, utilizando a instrução [continue](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/continue);
* Sair do for, utilizando as instruções ([goto](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/goto), [return](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/return) ou [throw](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/throw)).

Explicando cada parte do exemplo abaixo:
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

* Inicialização: int i = 0;
* Condição: i < 5;
* Incremento do Iterador: i++;
* Corpo: Console.WriteLine(i);

Obs.: Para as seções de inicialização, condição e iterador existem outras possibilidades de comandos conforme a referência abaixo.

**Referências:**
* [for statement](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/for#structure-of-the-for-statement)