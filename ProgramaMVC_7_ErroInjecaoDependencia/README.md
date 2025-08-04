
## Programa MVC 7: Erro de Injeção de Dependência

### Descrição do Problema
Este projeto MVC tenta utilizar um serviço (`IMeuServico`) injetado no controlador `HomeController` para exibir uma mensagem.

### Bug Intencional
O serviço `IMeuServico` não está registrado no contêiner de injeção de dependência do ASP.NET Core no arquivo `Program.cs`. Além disso, o construtor do `HomeController` não está recebendo `IMeuServico` como parâmetro, o que impede que a dependência seja injetada automaticamente. Isso resultará em uma `NullReferenceException` ao tentar acessar `_meuServico.GetMensagem()`.

### Objetivo
Identificar e corrigir o problema de injeção de dependência. O objetivo é registrar `IMeuServico` e sua implementação (`MeuServico`) no contêiner de DI e garantir que o `HomeController` receba a instância do serviço via injeção de construtor.

