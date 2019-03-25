# Lab 3: outros recursos do VS Code

_(Tempo estimado: 15 minutos)_

## Debugging

Vamos executar a aplicação criada no lab anterior no modo debugging.

Abra o VS Code no diretório **dotnet-training**.

Para adicionar um breakpoint em uma linha do código, basta clicar na extremidade esquerda da linha desejada (à esquerda do line number). O VS Code irá mostrar um ponto vermelho neste local.

Insira um breakpoint no método **Class1.GetMessage**, mais especificamente na linha:
```csharp
    return message;
```

Inicie o debug (VS Code > Debug > Start Debugging).

Se oriente pela toolbar exibida no topo para realizar o debugging (ex : step into, step over e break). Se preferir, passe o mouse sobre os botões para visualizar seus respectivos atalhos.

Passe o mouse sobre a variável "message" para visualizar o seu valor em tempo de execução.

Antes de encerrar o debugging, experimente avaliar expressões pelo Debug Console (VS Code > View > Debug Console). Na extremidade inferior há uma linha para inserir um comando, que será executado ao pressionar o botão enter. Teste, por exemplo:
* message
* message.ToUpper()
* message.Length == 10
* message = "Message changed by debug console" (note que esta expressão **altera** o valor da variável que será exibida no console, no momento em que a execução concluir)

## Testes

Agora vamos criar e executar um teste simples pelo VS Code.

Primeiro, crie um diretório para os projetos de teste dentro de **dotnet-training**::

```console
user:~$ cd dotnet-training
user:~$ mkdir test
user:~$ cd test
```

Em seguida, use a CLI para criar o projeto de teste e adicione-o à solution:

```console
user:~$ dotnet new xunit -n Training.Business.Tests
Project `test/Training.Business.Tests/Training.Business.Tests.csproj` added to the solution.

user:~$ cd ..
user:~$ dotnet sln add test/Training.Business.Tests
Project `test/Training.Business.Tests/Training.Business.Tests.csproj` added to the solution.
```

Pelo explorer do VS Code, veja que o template criou uma classe **UnitTest1**, com um método vazio **Test1**. Deixe-o como a seguir:
```csharp
[Fact]
public void Test1()
{
    var myNumber = 1;

    Assert.Equal(myNumber, 2);
}
```

Agora, execute o teste pelo VS Code. O teste também pode ser executado pela CLI usando o comando **dotnet test**.

Na paleta de ícones do canto esquerdo, clique em **Test**. Clique no botão **refresh** para que o VS Code identifique os testes. Você verá o **Test1** na lista.

Execute o teste clicando no botão play. Obviamente este teste irá falhar pois 1 != 2. Altere a linha do assert para que, desta vez, o teste passe.