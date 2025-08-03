
## Programa MVC 2: Erro de Roteamento

### Descrição do Problema
Este projeto MVC possui um controlador `HomeController` com uma ação `Contato` e uma view correspondente.

### Bug Intencional
A rota para a ação `Contato` não está configurada corretamente no arquivo `Program.cs`. Embora a ação e a view existam, a URL padrão do MVC não consegue mapear corretamente para `/Home/Contato` ou `/Contato`, resultando em um erro 404 (Not Found) ao tentar acessar a página de contato.

### Objetivo
Identificar e corrigir a configuração de roteamento no `Program.cs` para que a página de contato possa ser acessada corretamente através de uma URL amigável.

