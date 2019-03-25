# (Hands-on) Lab 3: string and dates

## Tempo

25 minutos.

## Preparação

1. Crie uma nova pasta:
    ```console
    user:~$ mkdir lab3-string-and-dates
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

## Problema 1

**MENSAGEM DE ENTRADA:** Entre com o texto e pressione enter:
**DADOS DE ENTRADA:** treinamento de dot net na cit

**PROCESSAMENTO:**
    * Formatar o texto de entrada letras maiusculas.
    * Substituir a palavra [DOT NET] por [.NET]

**MENSAGEM DE SAÍDA:** Texto formatado:
**INFORMAÇÃO DE SAÍDA:** TREINAMENTO DE .NET NA CIT.

## Problema 2

**MENSAGEM DE ENTRADA:** Entre com o texto e pressione enter:
**DADOS DE ENTRADA:** 1,

**PROCESSAMENTO:**
    * Adicione os próximos 9 números na string de entrada separando-os por vírgula.

**MENSAGEM DE SAÍDA:** Texto formatado:
**INFORMAÇÃO DE SAÍDA:** 1,2,3,4,5,6,7,8,9,10

## Problema 3

**MENSAGEM DE ENTRADA:** Entre uma data no formato DD/MM/AAAA HH:MM:SS e pressione enter:
**DADOS DE ENTRADA:** 22/03/2019 00:30:00

**PROCESSAMENTO:**
    * Aplicar a formatação esperada para a informação de saída.

**MENSAGEM DE SAÍDA:** Data formatada:
**INFORMAÇÃO DE SAÍDA:**
    ```
    22/03/2019
    00:30
    sexta-feira, 22 de março de 2019
    ```

## Problema 4

**MENSAGEM DE ENTRADA:** Entre uma data no formato DD/MM/AAAA HH:MM:SS e pressione enter:
**DADOS DE ENTRADA:** 22/03/2019 00:00:00

**PROCESSAMENTO:**
    * Incremente 1 dia, 4 horas, e 30 minutos na data de entrada.

**MENSAGEM DE SAÍDA:** Data incrementada:
**INFORMAÇÃO DE SAÍDA:** 23/03/2019 00:04:30

**Dicas:**
* Após a implementação e teste de cada problema, comente as linhas para implementar o próximo problema nas linhas abaixo.
* Utilize as referências em caso de dúvidas.
* Para ler o valor do console, utilize o método da classe System.Console.ReadLine().
* Para escrever as mensagens no console, utilize o método da classe System.Console.WriteLine().
* Para o problema 2 utilize o string builder.
