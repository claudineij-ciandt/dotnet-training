# (Hands-on) Lab 2: loops

## Tempo

15 minutos.

## Preparação

1. Crie uma nova pasta:
    ```console
    user:~$ mkdir lab2-loops
    ```

2. Abra o VS Code nesta pasta.

3. Abra o terminal integrado do VS Code (View > Terminal).

4. No terminal, crie um projeto do tipo console application:
    ```console
    user:~$ dotnet new console -lang C# -n ConsoleApp
    ```

5. Acesse o diretório do novo projeto:
    ```console
    user:~$ cd ConsoleApp
    ```

6. Abra a classe Program.cs utilizando o explorer do VS Code.

7. Apague o conteúdo do método Main.

8. Dentro do método Main, implemente uma lógica para resolver o problema descrito abaixo.

## Problema

**DADOS DE ENTRADA:** Nenhum.

**PROCESSAMENTO:**

* **REGRA1:**
    * Para a sequência de 1 a 10, identifique os números pares.
        * **MENSAGEM DE SAÍDA:**
        ```
        Loop utilizado: [for]
        Números pares abaixo:
        Escreva no console os números pares desta sequência.
        ```

* **REGRA2:**
    * Identifique todos os números que sejam maiores ou iguais a 0 e menores ou iguais a 5.
        * **MENSAGEM DE SAÍDA:**
        ```
        Loop: [while]
        Números da sequência:
        Escreva no console os números desta sequência iterativa.
        ```

**Dicas:**
* Utilize o operador % para identificar os resto da divisão e, assim, identificar os números pares. Exemplo: N%2 == 0.
* Utilize os statements for e while para implementar as regras, e identifique qual melhor atende cada uma delas.
* Para escrever as mensagens no console, utilize o método da classe System.Console.WriteLine().
* Se necessário, consulte a documentação de referência: [for statement](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/for#structure-of-the-for-statement), [while statement](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/while).