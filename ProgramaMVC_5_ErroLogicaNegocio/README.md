
## Programa MVC 5: Erro de Lógica de Negócio

### Descrição do Problema
Este projeto MVC possui um controlador `CalculadoraController` com uma ação `Somar` que recebe dois números inteiros.

### Bug Intencional
Dentro da ação `Somar`, a operação realizada é uma subtração (`a - b`) em vez de uma soma (`a + b`). Isso é um erro de lógica de negócio que fará com que o programa retorne um resultado incorreto para a operação de soma.

### Objetivo
Identificar e corrigir a operação matemática na ação `Somar` do `CalculadoraController` para que ela realize a soma correta dos dois números, retornando o resultado esperado.

