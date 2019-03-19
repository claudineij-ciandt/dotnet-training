# A classe Startup

ASP.NET Core usa uma classe de inicialização para configuração de serviços e pipeline da sua aplicação. Ela é especificada e construída na classe `host`. A classe é composta de dois métodos de configuração:

- `ConfigureServices` é usado para configurar(ou registrar) serviços usados pelo aplicação.

- `Configure` é usando para adiciona um tratamento(`middleware`) ao pipeline da requisição. Cada `middleware` adicionado, executa uma operação e invoca o próximo `middleware`. Por exemplo, um `middleware` pode manipular as solicitações para arquivos estáticos ou redirecionar solicitações HTTP para HTTPS.