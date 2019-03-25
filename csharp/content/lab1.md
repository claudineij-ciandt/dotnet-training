# (Hands-on) Lab 1: conditions

## Tempo

20 minutos.

## Preparação

1. Crie uma nova pasta:
    ```console
    user:~$ mkdir lab1-conditions
    ```

2. Abra o VS Code nesta pasta.

3. Abra o terminal integrado do VS Code (View > Terminal).

4. No terminal, crie um projeto do tipo console application:
    ```console
    user:~$ dotnet new console -lang C# -n ConsoleApp
    ```

5. Neste momento, o VS Code pode ter exibido uma pop-up com a mensagem **"Required assets to build and debug are missing from your project, add them?"**. Se sim, selecione **yes**: será criado um diretório **.vscode**, com 2 arquivos JSON, na raiz da solution. Este arquivos são criados pela extensão **C#** apenas uma vez, com o intuito de orientar o VS Code em ações de build e debug da solution.

    Caso a mensagem não tenha aparecido:
    * Verifique se o diretório ".vscode" já existe. Se existir, pronto! Não é necessário executar os passos abaixo.
    * Abra a paleta de comandos (VS Code > View > Command Palette) e selecione **.NET: Generate Assets for Build and Debug**.
    * Se ainda não funcionar, reinicie o VS Code e repita os passos acima.

6. Altere o arquivo .vscode/launch.json, modificando o valor da propriedade "console":
    ```json
    "console": "integratedTerminal",
    ```

7. Acesse o diretório do novo projeto:
    ```console
    user:~$ cd ConsoleApp
    ```

8. Abra a classe Program.cs utilizando o explorer do VS Code.

9. Apague o conteúdo do método Main.

10. Dentro do método Main, implemente uma lógica para resolver o problema descrito abaixo.

## Problema

**DADOS DE ENTRADA:** Informe um número e pressione enter.

**PROCESSAMENTO:**

* **REGRA1:**
    * Os valores possíveis que o usuário pode informar vão de 1 a 100.
    * Caso seja informado um valor fora deste range:
        * **MENSAGEM DE SAÍDA:**  Valor é inválido para o sorteio. Por favor entre com um valor de 1 a 100.

* **REGRA2:**
    * Os valores 40, 75, 90 dão um carro de brinde para o usuário que informar um destes valores no console.
    * Caso o usuário acerte um dos números, devemos exibir a seguinte mensagem para o usuário:
        * **MENSAGEM SAÍDA:** Sortudo, ganhou um carro!!!.
    * Caso contrário, devemos exibir a seguinte mensagem para o usuário:
        * **MENSAGEM DE SAÍDA:** Tente novamente, quem sabe você ganha!

**Dicas:**
* Para ler o valor do console, utilize o método da classe System.Console.ReadLine()
* Para converter o valor lido para int, utilize o método da classe System.Convert.ToInt32()
* Para escrever as mensagens no console, utilize o método da classe System.Console.WriteLine()
* Se precisar, consulte os operadores da linguagem [aqui](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/#logical-and-operator).
