# Lab 1: setup do ambiente de desenvolvimento .NET

_(Tempo estimado: 30 minutos)_

Vamos começar realizando o setup do ambiente de desenvolvimento. O setup inclui a instalação do SDK do .NET Core e ferramentas de apoio.

1. [Instale o .NET Core 2.2 SDK](#1-instale-o-net-core-22-sdk)
    1. [Valide a instalação](#11-valide-a-instalação)
2. [Instale o VS Code](#2-instale-o-vs-code)
    1. [Instale extensões no VS Code](#21-instale-extensões-no-vs-code)
3. [Instale o Postman](#3-instale-o-postman)

## 1. Instale o .NET Core 2.2 SDK

O .NET Core SDK contém aplicações e bibliotecas necessárias para desenvolver, compilar e executar aplicações .NET Core.

Acesse a [página de download do .NET Core](https://dotnet.microsoft.com/download/).

Escolha seu sistema operacional (e, no caso do Linux, também a distribuição).

Selecione a opção "Download/Install .NET Core SDK". Conclua a instalação após o download.

### 1.1. Valide a instalação

Execute o comando abaixo e compare com o resultado esperado:

```console
user:~$ dotnet --list-sdks
2.2.x [/usr/share/dotnet/sdk]
```

## 2. Instale o VS Code

Existem vários editores e IDEs que suportam o desenvolvimento na plataforma .NET. Neste treinamento usaremos o VS Code, um editor gratuito, multilinguagem e multiplataforma.

Acesse a [página de download do VS Code](https://code.visualstudio.com/Download).

Escolha seu sistema operacional (e, no caso do Linux, também a distribuição). Conclua a instalação após o download.

## 2.1. Instale extensões no VS Code

O VS Code é também bastante extensível e customizável. No Marketplace há extensões disponíveis para os mais diversos propósitos e linguagens.

Abra o VS Code e, no menu lateral, selecione "Extensions".

Pesquise e instale as 4 extensões a seguir:

* **C#**: C# for Visual Studio Code (powered by OmniSharp)

* **C# Extensions**: C# IDE Extensions for VSCode

* **.NET Core Test Explorer**: Test Explorer for .NET Core (MSTest, xUnit, NUnit)

* **VS Live Share**: Real-time collaborative development from the comfort of your favorite tools

## 3. Instale o Postman

Em alguns labs iremos desenvolver e testar APIs através de requisições HTTP. Para tal, podemos utilizar o Postman.

Caso você já tenha o Postman ou outra ferramenta similar, pule esta etapa.

Acesse a [página de download do Postman](https://www.getpostman.com/downloads/). Conclua a instalação após o download. Se necessário, [veja aqui](https://learning.getpostman.com/docs/postman/launching_postman/installation_and_updates/) instruções de instalação para o Linux.