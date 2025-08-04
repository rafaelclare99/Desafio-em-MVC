
## Programa MVC 6: Erro de Renderização de View

### Descrição do Problema
Este projeto MVC possui um controlador `ProdutosController` com uma ação `Detalhes` que deveria exibir os detalhes de um produto.

### Bug Intencional
A view `Detalhes.cshtml` espera receber um modelo do tipo `Produto` (`@model ProgramaMVC_6_ErroRenderizacaoView.Models.Produto`). No entanto, a ação `Detalhes` no controlador não está passando nenhum modelo para a view (`return View();`). Isso resultará em um erro em tempo de execução (NullReferenceException) quando a view tentar acessar propriedades de um modelo nulo, como `@Model.Nome` ou `@Model.Preco`.

### Objetivo
Identificar e corrigir o erro de renderização da view. O objetivo é garantir que a ação `Detalhes` no controlador passe um objeto `Produto` válido para a view, mesmo que seja um objeto vazio ou com dados de exemplo, para evitar a exceção de referência nula.

