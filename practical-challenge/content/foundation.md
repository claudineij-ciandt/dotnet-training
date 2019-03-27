# [Non-Functional Task] Criar o foundation

## Visão geral

Realizar o foundation necessário para o desenvolvimento das próximas estórias. O escopo do foundation inclui os seguintes pontos:
* Realizar o setup da aplicação frontend;
* Criar uma solution;
* Criar um projeto Web API;
* Criar um projeto Business;
* Criar um projeto Repository;
* Habilitar o Entity Framework Core (utilizando um banco in-memory).

## Frontend

A aplicação frontend está pronta e não necessita de nenhuma alteração. No entanto, é necessário realizar o setup desta aplicação no seu ambiente local, o que irá validar a integração entre o frontend e o backend.

Verifique se o **Node.js** e o **npm** estão instalados em sua máquina. Não é necessário que eles estejam exatamente nas mesmas versões do exemplo abaixo.

```console
user:~$ node --version
10.15.3

user:~$ npm --version
6.4.1
```

Caso não esteja instalado, acesse a [página de downloads do Node.js](https://nodejs.org/en/download/) e realize o setup. Execute novamente as etapas anteriores para validar a instalação.

Baixe o [repositório do treinamento](https://github.com/claudineij-ciandt/dotnet-training). Não é mandatório realizar o git clone (pode-se realizar apenas o download do .zip), uma vez que sua solução não será versionada neste repositório.

O diretório da aplicação frontend estará em **dotnet-training/practical-challenge/frontend**. Você pode copiar esta pasta para outro local ou executar a aplicação a partir dela mesma.

Restaure as dependências da aplicação:
```console
user:~$ cd frontend

user:~$ npm install
added 1220 packages from 669 contributors and audited 23856 packages in 140.382s
```

Execute a aplicação:
```console
user:~$ npm run serve
App running at:
 - Local: http://localhost:8080/
```

Pronto! Sua aplicação frontend está funcionando e pode ser acessada pela porta 8080. Quando sua aplicação backend estiver minimamente funcional, execute-a para estabelecer a troca de informações com o frontend.s

## Solution, projetos e dependências

A estrutura de diretórios deve seguir o desenho abaixo:
```
my-solution-folder
├── src
│    ├── first-application-project
│    ├── second-application-project
|    └── third-application-project
└── MySolution.sln
```

É importante observar a ordem de dependência entre as camadas: API -> Business -> Repository. Porém, o projeto API deve conhecer o projeto Repository para realizar o registro dos serviços no container de injeção de dependência. Utilize estas informações para definir as referências entre os projetos.

Para criar solutions, projetos e adicionar dependências, refira-se ao [lab do dotnet CLI](https://github.com/claudineij-ciandt/dotnet-training/blob/master/introduction/content/introduction-lab-2.md).

## Entity Framework

Para habilitar o Entity Framework, primeiro inclua a library **Microsoft.EntityFrameworkCore.InMemory (by: Microsoft EntityFramework aspnet)** no projeto Repository. Depois, faça o setup do DbContext. Se necessário, relembre-se destes passos [no lab do Entity Framework](https://github.com/claudineij-ciandt/dotnet-training/blob/master/aspnet-core/labs/lab5-efcore/README.md).