# Estrutura de repetição while

Executa um comando ou bloco de comandos enquanto uma condição iterativa for verdade.

Em qualquer parte do (body) corpo da instrução while, podemos:
* Parar/sair a execução dos comandos e sair do while, utilizando a instrução [break](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/break);
* Continuar, indo para a próxima iteração, utilizando a instrução [continue](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/continue);
* Sair do while, utilizando as instruções ([goto](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/goto), [return](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/return) ou [throw](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/throw)).

Exemplos:
```csharp
int n = 0;
while (n < 5)
{
    Console.WriteLine(n);
    n++;
}
```

Explicando cada parte do exemplo abaixo:

* Condição para iteração: while (n < 5)
* Corpo: { Incremento do Iterador = i++; }
* Incremento do Iterador: n++;
    * **Obs.: caso o iterador não seja incrementado, a condição para iteração será sempre verdadeira e a aplicação entrará em um loop eterno.**

**Referências:**
* [while statement](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/while)