# Introdução ao .NET

## O que é .NET?
o .NET é uma plataforma de desenvolvimento para diversos tipos de aplicações, incluindo:
* Web
* Mobile
* Desktop
* Gaming
* IoT

O primeira versão do .NET foi lançada pela Microsoft em 2002. Desde então, mudanças significativas aconteceram:

![.NET history](/media/dotnet-history.png)

Em 2014, a Microsoft anunciou o desenvolvimento da próxima geração do ASP.NET, então chamado de ASP.NET vNext. Esta nova versão trouxe novas e importantes características:
* Cloud-optimized: idealizado para aplicações cloud-native, otimizada para cenários de baixa memória e alto throughput.
* Open-souce: código aberto para todo o framework, incluindo o runtime, compiladores e bibliotecas.
* Cross-platform: executável em sistemas operacionais Windows, Linux e macOS.

O ASP.NET vNext foi inicialmente denominado ASP.NET 5. Porém, as mudanças foram tão significativas que elas deram origem a uma nova implementação do .NET, o .NET Core.

Atualmente, .NET é um umbrella-term para as diversas implementações .NET, seus frameworks de aplicação, bibliotecas e infraestrutura compartilhada.

![.NET architecture](/media/dotnet-architecture.png)

## Como funcionam as aplicações .NET?

Aplicações .NET, quando compiladas, são hardware-agnostic. Em especial, aplicações .NET Core são cross-platform and cross-architecture, isto é, a mesma aplicação é executada de forma consistente no Windows, Linux e macOS, e em diferentes tipos de computadores ou processadores, incluindo x64, x86 e ARM.

O desenvolvimento também não está restrito a apenas uma linguagem.

![.NET compilation and execution process](/media/dotnet-compilation-execution.png)

Cada linguagem tem seu compilador específico. O código-fonte é compilado para uma linguagem intermediária (assemblies). Ao ser executado, o runtime possui um compilador chamado JIT (just-in-time compiler), que faz a compilação para código nativo de máquina.