# Lab: dotnet CLI

O dotnet CLI é uma ferramenta para executar diversas operações úteis para o desenvolvimento de aplicações .NET Core. Embora muitas destas operações estejam disponibilizadas na interface gráfica de IDEs, a CLI é o método _out-of-the-box_ para realizá-las.

Neste lab, vamos utilizar alguns dos principais comandos da CLI.

1. [Explore a CLI](#1-explore-a-cli)
2. [Crie uma solution](#2-crie-uma-solution)
3. [Crie um projeto console](#3-crie-um-projeto-console)
4. [Execute e teste a aplicação console](#4-execute-e-teste-a-aplicação-console)
5. [Adicione uma dependência interna](#5-adicione-uma-dependência-interna)
6. [Adicione uma dependência externa](#6-adicione-uma-dependência-externa)


## 1. Explore a CLI

Liste os comandos oferecidos pela CLI e observe o resultado:

```console
user:~$ dotnet --help
SDK commands:
  add               Add a package or reference to a .NET project.
  build             Build a .NET project.
  build-server      Interact with servers started by a build.
  clean             Clean build outputs of a .NET project.
  (...)
```

A CLI oferece alguns templates de projetos e arquivos para aplicações .NET Core. Liste-os e observe as opções:

```console
user:~$ dotnet new
Templates                                         Short Name         Language          Tags
----------------------------------------------------------------------------------------------------------------------------
Console Application                               console            [C#], F#, VB      Common/Console
Class library                                     classlib           [C#], F#, VB      Common/Library
Unit Test Project                                 mstest             [C#], F#, VB      Test/MSTest
(...)
```

## 2. Crie uma solution

O código-fonte e arquivos que compõem uma aplicação .NET são organizados em **projects** e **solutions**.

Um **project** é uma unidade mínima de build e deploy. Ele é constituído por múltiplos arquivos que, ao serem buildados, se tornam um único arquivo compilado.

Uma **solution** é um agrupador de projetos relacionados. Durante o desenvolvimento é bastante comum, por exemplo, fazer o build da solution ao invés do build de projetos, o que faz com que todos os projetos relacionados sejam buildados. Ao contrário do que o nome possa sugerir, uma solution não é necessariamente uma "resposta" ou solução de um problema.

Crie um diretório para a solution:

```console
user:~$ mkdir dotnet-training
```

Abra o VS Code e carregue o diretório recém criado (VS Code > File > Open Folder > dotnet-training). Em seguida, exiba o terminal integrado do VS Code e utilize-o para executar os comandos seguintes (VS Code > View > Terminal).

Crie uma solution chamada "Training":

```console
user:~$ dotnet new sln -n Training
The template "Solution File" was created successfully.
```

Builde a solution:
```console
user:~$ dotnet build
Build succeeded.
Warning : Unable to find a project to restore!
```

Recebemos um alerta dizendo que não foi encontrado nenhum projeto nesta solution. Este será o próximo passo.

## 3. Crie um projeto console

Uma estrutura de diretórios bastante utilizada em aplicações .NET é a seguinte:

```
my-solution-folder
├── src
│    ├── first-application-project
│    ├── second-application-project
|    └── third-application-project
├── test
│    ├── first-test-project
│    └── second-test-project
└── MySolution.sln
```

Crie um projeto dentro de **dotnet-training/src**. Este projeto irá utilizar o template **Console Application**:

```console
user:~$ mkdir src
user:~$ cd src
user:~$ dotnet new console -n Training.ConsoleApp
The template "Console Application" was created successfully.
```

Builde a solution novamente:

```console
user:~$ cd ..
user:~$ dotnet build
Build succeeded.
Warning : Unable to find a project to restore!
```

O warning ainda está presente mesmo após criarmos um projeto. Por quê?

O projeto foi criado, porém ele não foi adicionado (associado) à solution. Adicione-o e repita o build:

```console
user:~$ dotnet sln add src/Training.ConsoleApp/
Project `src/Training.ConsoleApp/Training.ConsoleApp.csproj` added to the solution.

user:~$ dotnet build
Build succeeded.
```

## 4. Execute e teste a aplicação console

Neste momento, após adicionar o primeiro projeto à solution, o VS Code pode ter exibido uma pop-up com a mensagem **"Required assets to build and debug are missing from your project, add them?"**. Se sim, selecione **yes**: será criado um diretório **.vscode**, com 2 arquivos JSON, na raiz da solution. Este arquivos são criados pela extensão **C#** apenas uma vez, com o intuito de orientar o VS Code em ações de build e debug da solution.

Caso a mensagem não tenha aparecido:
* Verifique se o diretório ".vscode" já existe. Se existir, pronto! Não é necessário executar os passos abaixo.
* Abra a paleta de comandos (VS Code > View > Command Palette) e selecione **.NET: Generate Assets for Build and Debug**.
* Se ainda não funcionar, reinicie o VS Code e repita os passos acima.

Explore os arquivos gerados pelo template (VS Code > View > Explorer > dotnet-training > src > Training.ConsoleApp). Em especial, veja o conteúdo do arquivo **Program**. Ao executar a aplicação, a mensagem "Hello World!" será exibida no output do console.

Execute a aplicação console:

```console
user:~$ cd src/Training.ConsoleApp
user:~$ dotnet run
Hello World!
```

## 5. Adicione uma dependência interna

A classe **Program** exibe uma mensagem _hard-coded_ no próprio método. Em aplicações reais, os sistemas são geralmente organizados em camadas: a camada superior é um adapter para o meio externo (console, Internet, etc.), enquanto as camadas inferiores tratam regras de negócio e acessam mecanismos de armazenamento, por exemplo.

Crie um projeto dentro de **dotnet-training/src**. Este projeto irá utilizar o template **Class Library**. Em seguida, adicione-o à solution:

```console
user:~$ cd src
user:~$ dotnet new classlib -n Training.Business
The template "Class library" was created successfully.

user:~$ cd ..
user:~$ dotnet sln add src/Training.Business/
Project `src/Training.Business/Training.Business.csproj` added to the solution.
```

Explore os arquivos gerados pelo template Class Library (VS Code > View > Explorer > dotnet-training > src > Training.Business). Observe a classe **Class1**, criada como exemplo.

Na "Class1", adicione um método que retorna uma mensagem customizada. Em seguida, altere **Programa.Main** para invocar este método e retornar a nova mensagem.


Adcione o método abaixo na **Class1**:

```csharp
public static string GetMessage() {
    return "A custom message generated by the business layer";
}
```

Altere o método **Program.Main** para invocar e retornar **Class1.GetMessage**.

```csharp
static void Main(string[] args)
{
    Console.WriteLine(Class1.GetMessage());
}
```

Após esta alteração, "Class1" é sublinhado com vermelho, indicando um erro de compilação. Ao mover o mouse sobre "Class1", ou visualizando os Problems (VS Code > View > Problems), obtemos o erro **The name 'Class1' does not exist in the current context [Training.ConsoleApp]**. Qual o problema?

Primeiro, é necessário adicionar uma referência do projeto **Training.Business** no projeto **Training.ConsoleApp**. Dizemos que o projeto **Training.Business** é uma dependência do projeto **Training.ConsoleApp**.

```console
user:~$ cd src/Training.ConsoleApp
user:~$ dotnet add reference ../Training.Business/
Reference `..\Training.Business\Training.Business.csproj` added to the project.
```

No entanto, o erro ainda permanece. Por quê?

Agora resta apenas adicionar a diretiva de importação no arquivo. Clique no ícone de lâmpada à esquerda, na mesma linha do erro. Escolha a opção **using Training.Business**. Observe o bloco de **usings**, no início do arquivo. Dentre eles está a opção recém adicionada.

Execute e teste novamente a aplicação console:

```console
user:~$ cd src/Training.ConsoleApp
user:~$ dotnet run
A custom message generated by the business layer
```

## 6. Adicione uma dependência externa

O **NuGet** é o gerenciador de pacotes do .NET. Ele se utiliza do **NuGet Gallery**, o principal repositório público de pacotes .NET. Outros repositórios também podem ser utilizados, inclusive privados.

Nesta etapa, vamos demonstrar como adicionar e utilizar uma biblioteca externa. Utilizaremos um gerador de _lorem ipsum_ para alterar a mensagem do método **Class1.GetMessage**.

Acesse o [NuGet Gallery](https://www.nuget.org/).

Pesquise por "lorem". Encontre e escolha a opção **Lorem.Universal.NET**, by trichards57.

Clique na aba **.NET CLI** e copie o comando gerado.

Adicione o pacote ao projeto **Training.Business**.

```console
user:~$ dotnet add package Lorem.Universal.Net --version 2.1.55
PackageReference for package 'Lorem.Universal.Net' version '2.1.55' added to file 'dotnet-training/src/Business/Business.csproj'.
Restore completed for 'dotnet-training/src/Business/Business.csproj'.
```

Altere o método **Class1.GetMessage**:

```csharp
public static string GetMessage() {
    return Lorem.Words(5);
}
```

Adicione a diretiva de importação para a classe **Lorem** (ícone lâmpada > using LoremNET).

Execute e teste novamente a aplicação console:

```console
user:~$ cd src/Training.ConsoleApp
Maecenas neque leo dui tellus
```