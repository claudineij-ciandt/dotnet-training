# Hands-on Lab #4 - Criar configurações para Aplicação

## Visão Geral
Criar uma API que lê as configurações do sistema via `appsettings.json`.

## Pré-Requisito
- Visual Studio ou VS Code
- .NET Framework instalado
- Postman ou similar

### Requisitos

- Criar aplicação webapi
- Criar as seguintes configurações do sistema no arquivo `appsettings.json`
    - Key: BancoDados / Value: sqlserver
    - Key: DatabaseName / Value: lab3-configuration

- Criar modelo que reflete as configurações
- Criar controller que receba as configurações via construtor 
- Retornar configurações via action HTTP Get