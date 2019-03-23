# Estrutura de repetição do while

Essa instrução é muito parecida com o while. A única diferença é que ela executa um bloco de comandos pelo menos 1 vezes e, só depois, começa a analisar a condição para executar ou não uma próxima iteração.

Normalmente se utiliza esta estrutura quando precisamos requisitar informações na primeira iteração e, a partir daí, começar a avaliar a condição de parada.

Em qualquer parte do (body) corpo da instrução do-while, podemos:
* Parar/sair a execução dos comandos e sair do do-while, utilizando a instrução [break](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/break);
* Continuar, indo para a próxima iteração, utilizando a instrução [continue](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/continue);
* Sair do do-while, utilizando as instruções ([goto](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/goto), [return](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/return) ou [throw](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/throw)).

Exemplos:
```csharp
int n = 0;
do
{
    Console.WriteLine(n);
    n++;
} while (n < 5);
```

**Referências:**
* [do while statement](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/do)