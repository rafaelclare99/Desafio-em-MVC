
## Programa MVC 10: Erro de Acesso a Dados (SQL Injection)

### Descrição do Problema
Este projeto MVC possui um controlador `UsuariosController` com uma ação `Buscar` que tenta pesquisar usuários em um banco de dados com base em um nome fornecido.

### Bug Intencional
A consulta SQL na ação `Buscar` é construída diretamente concatenando a entrada do usuário (`nomeUsuario`) na string da consulta. Isso torna o programa vulnerável a ataques de SQL Injection, onde um usuário mal-intencionado pode inserir código SQL na entrada para manipular a consulta e acessar ou modificar dados não autorizados.

### Objetivo
Identificar e corrigir a vulnerabilidade de SQL Injection. O objetivo é reescrever a consulta SQL para usar parâmetros parametrizados (prepared statements) em vez de concatenação de strings, garantindo que a entrada do usuário seja tratada como dados e não como parte do código SQL.

