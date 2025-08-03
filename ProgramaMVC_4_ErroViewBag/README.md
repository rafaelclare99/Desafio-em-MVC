
## Programa MVC 4: Erro ao usar ViewBag

### Descrição do Problema
Este projeto MVC tenta exibir uma mensagem de boas-vindas na página inicial usando `ViewBag`.

### Bug Intencional
No controlador `HomeController`, a mensagem é armazenada na `ViewBag` com o nome `MensagemBoasVindas`. No entanto, na view `Index.cshtml`, a tentativa de acessar essa mensagem é feita usando um nome incorreto: `@ViewBag.MensagemDeBoasVindas`. Isso resultará na mensagem não sendo exibida na página, pois a propriedade com o nome errado não existe na `ViewBag`.

### Objetivo
Identificar e corrigir o nome da propriedade `ViewBag` na view `Index.cshtml` para que corresponda ao nome usado no controlador (`MensagemBoasVindas`), garantindo que a mensagem seja exibida corretamente na página.

