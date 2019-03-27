# (Hands-on) Lab 4: LINQ

Neste lab você irá praticar o uso do foreach e do LINQ.

Você irá implementar uma query utilizando o LINQ e outra sem utilizá-lo. No fim, observe os resultados e note a expressividade que o uso do LINQ proporciona.

## Tempo

30 minutos.

## Preparação

1. Crie uma nova pasta:
    ```console
    user:~$ mkdir lab4-foreach-and-linq
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

9. Substitua todo o conteúdo do arquivo Program.cs pelo seguinte:
    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace ConsoleApp
    {
        public class Compra
        {
            public string Cliente { get; set; }
            public decimal Valor { get; set; }
            public bool PagamentoRealizado { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var compras = new List<Compra>
                {
                    new Compra { Valor = 20, PagamentoRealizado = true , Cliente = "João" },
                    new Compra { Valor = 10, PagamentoRealizado = true , Cliente = "Maria" },
                    new Compra { Valor = 80, PagamentoRealizado = false, Cliente = "Tereza" },
                    new Compra { Valor = 30, PagamentoRealizado = true , Cliente = "José" },
                    new Compra { Valor = 10, PagamentoRealizado = false, Cliente = "João" },
                    new Compra { Valor = 20, PagamentoRealizado = true , Cliente = "João" },
                    new Compra { Valor = 20, PagamentoRealizado = false, Cliente = "Tereza" },
                    new Compra { Valor = 40, PagamentoRealizado = true, Cliente = "Maria" },
                    new Compra { Valor = 30, PagamentoRealizado = true , Cliente = "João" },
                    new Compra { Valor = 10, PagamentoRealizado = false, Cliente = "Tereza" }
                };

                Console.WriteLine($"Valor total a receber: {ValorTotalAReceber(compras)}");
                Console.WriteLine($"Devedores: {string.Join(", ", ClientesDevedores(compras))}");
            }

            // Soma o valor de todas compras não pagas.
            // Resultado esperado: 120
            private static decimal ValorTotalAReceber(List<Compra> compras)
            {
                return compras.Where(x => !x.PagamentoRealizado)
                                .Sum(x => x.Valor);
            }

            // Seleciona os nomes dos clientes que têm compras não pagas.
            // Resultado esperado: Tereza, João
            private static IEnumerable<string> ClientesDevedores(List<Compra> compras)
            {
                var devedores = new List<string>();

                foreach (var compra in compras)
                {
                    if (!compra.PagamentoRealizado)
                    {
                        if (!devedores.Contains(compra.Cliente))
                        {
                            devedores.Add(compra.Cliente);
                        }
                    }
                }

                return devedores;
            }
        }
    }
    ```

## Problema 1

**DADOS DE ENTRADA:** Nenhum

**PROCESSAMENTO:**
* O método ValorTotalAReceber utiliza LINQ. Comente o seu conteúdo e reescreva-o sem utilizar LINQ.
* Dica: utilize o foreach para iterar sobre a lista de compras.

**INFORMAÇÃO DE SAÍDA:**
    ```
    Valor total a receber: 120
    Devedores: Tereza, João
    ```

## Problema 2

**DADOS DE ENTRADA:** Nenhum

**PROCESSAMENTO:**
* O método ClienteDevedores não utiliza LINQ. Comente o seu conteúdo e reescreva-o utilizando LINQ.
* Dica: utilize os método Where, Select e Distinct.

**INFORMAÇÃO DE SAÍDA:**
    ```
    Valor total a receber: 120
    Devedores: Tereza, João
    ```

**Observe e compare as implementações com LINQ e sem LINQ.**