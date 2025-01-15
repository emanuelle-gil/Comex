# Sistema de Empréstimo de Livros

Este é um sistema de console em C# para o gerenciamento de empréstimos de livros, permitindo o cadastro de usuários, livros e o controle de empréstimos com regras específicas.

## Funcionalidades

- **Cadastro de usuários**: Validação de CPF (sem duplicidade).
- **Cadastro de livros**: Registro de livros na biblioteca.
- **Empréstimo de livros**: Um usuário pode emprestar até 3 livros simultaneamente, e um livro deve ser devolvido antes de novo empréstimo.
- **Devolução de livros**: Permite a devolução de livros emprestados.
- **Consulta de livros disponíveis**: Exibe livros não emprestados.

## Estrutura do Projeto

- **Livro**: Com propriedades como título, autor, ISBN, e métodos para emprestar, devolver e exibir informações.
- **Usuario**: Contém nome, CPF, e uma lista de livros emprestados, com métodos para emprestar, devolver e exibir histórico.
- **Biblioteca**: Gerencia livros e usuários, com métodos para adicionar/remover livros, registrar usuários e exibir livros disponíveis.

