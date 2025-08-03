
## Programa MVC 3: Erro de Tipo de Dados

### Descrição do Problema
Este projeto MVC define um modelo `Produto` que inclui um campo para o preço do produto.

### Bug Intencional
O campo `Preco` no modelo `Produto` foi definido como `string` em vez de um tipo numérico apropriado (como `decimal` ou `double`). Isso impede que operações matemáticas sejam realizadas diretamente com o valor do preço e pode levar a erros de conversão ou lógica incorreta ao tentar processar esses dados.

### Objetivo
Identificar e corrigir o tipo de dado do campo `Preco` no modelo `Produto` para um tipo numérico adequado, garantindo que o preço possa ser manipulado corretamente em cálculos e validações.

