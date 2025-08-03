
## Programa MVC 1: Erro de Validação de Modelo

### Descrição do Problema
Este projeto MVC simula o cadastro de um cliente, onde o modelo `Cliente` possui regras de validação de dados (DataAnnotations).

### Bug Intencional
O campo `Nome` no modelo `Cliente` possui uma validação `StringLength` com um tamanho máximo muito pequeno (5 caracteres). Isso fará com que a maioria dos nomes válidos inseridos pelo usuário falhe na validação, mesmo que o nome seja razoável, impedindo o cadastro.

### Objetivo
Identificar e corrigir a validação do campo `Nome` no modelo `Cliente` para um tamanho mais apropriado, permitindo que nomes de clientes comuns sejam aceitos pelo sistema.

