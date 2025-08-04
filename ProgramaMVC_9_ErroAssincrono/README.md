
## Programa MVC 9: Erro em Operação Assíncrona

### Descrição do Problema
Este projeto MVC possui um controlador `DadosController` com uma ação `ObterDados` que simula uma operação assíncrona demorada para buscar dados.

### Bug Intencional
Dentro da ação `ObterDados`, a chamada para `SimularOperacaoAssincrona()` não está sendo `await`ada corretamente. Em vez disso, `dadosTask.Result` está sendo usado para obter o resultado da tarefa. Isso bloqueia a thread principal do servidor web enquanto a operação assíncrona está em andamento, o que pode levar a problemas de desempenho, como deadlocks ou baixa escalabilidade, especialmente sob carga.

### Objetivo
Identificar e corrigir o uso incorreto de operações assíncronas. O objetivo é modificar a ação `ObterDados` para usar `await` com `SimularOperacaoAssincrona()`, garantindo que a operação assíncrona seja executada de forma não bloqueante e que o servidor possa lidar com outras requisições enquanto aguarda o resultado.

