# A classe Startup

ASP.NET Core usa uma classe de inicialização para a configuração de serviços e do pipeline da sua aplicação. Ela é especificada e construída na classe *host*. A classe é composta de dois métodos de configurações:

- `ConfigureServices` é usado para configurar (ou registrar) serviços usados pelo aplicação.

- `Configure` é usando para adicionar um tratamento (*middleware*) ao pipeline da requisição.