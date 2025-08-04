
## Programa MVC 8: Erro de Autenticação/Autorização

### Descrição do Problema
Este projeto MVC possui um controlador `AdminController` com uma ação `Index` que é decorada com o atributo `[Authorize]`, indicando que apenas usuários autenticados e autorizados podem acessá-la.

### Bug Intencional
O projeto não possui nenhuma configuração de autenticação ou autorização habilitada no `Program.cs`. Embora o atributo `[Authorize]` esteja presente, não há um middleware de autenticação configurado para processar as credenciais do usuário ou um provedor de autorização para verificar as permissões. Isso fará com que o acesso à página de administração seja negado ou que o sistema não se comporte como esperado em relação à segurança.

### Objetivo
Identificar e corrigir o problema de autenticação/autorização. O objetivo é configurar um esquema de autenticação (por exemplo, Cookie Authentication) e, se necessário, um esquema de autorização no `Program.cs` para que o atributo `[Authorize]` funcione corretamente, protegendo a área administrativa.

