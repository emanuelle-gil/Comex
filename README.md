# Projeto SQL - Gestão de Clientes e Pedidos

Este projeto tem como objetivo aplicar o conhecimento adquirido em SQL para a criação e manipulação de tabelas em PostgreSQL, focando na definição de chaves primárias e estrangeiras, inserção de dados, consultas, atualizações e exclusões de registros.

## Objetivos do Projeto

- **Criar tabelas** para armazenar dados de clientes e pedidos, utilizando tipos de dados adequados e garantindo a integridade referencial com chaves primárias e estrangeiras.
- **Inserir dados** nas tabelas criadas, assegurando a associação correta entre clientes e pedidos.
- **Realizar consultas** para extrair e filtrar dados de forma eficiente, incluindo o uso de cláusulas `WHERE`, `ORDER BY`, e `JOIN`.
- **Modificar e excluir dados** utilizando os comandos `UPDATE` e `DELETE`.

## Estrutura do Projeto

O projeto é dividido em etapas, cada uma com um conjunto de tarefas que envolvem a criação de tabelas, inserção de dados, consultas e modificações nas tabelas. Abaixo estão os detalhes de cada etapa:

### 1. Criação da Tabela `Clientes`

A primeira tarefa foi criar a tabela **Clientes** com as seguintes especificações:

- **ID**: Chave primária, tipo `INTEGER`, auto-incrementada.
- **Nome**: Tipo `TEXT`, armazena o nome completo do cliente.
- **Email**: Tipo `TEXT`, armazena o email do cliente.
- **DataNascimento**: Tipo `DATE`, armazena a data de nascimento do cliente.
- **Cidade**: Tipo `TEXT`, armazena a cidade onde o cliente reside.

### 2. Criação da Tabela `Pedidos`

A segunda tarefa envolveu a criação da tabela **Pedidos** com as seguintes especificações:

- **PedidoID**: Chave primária, tipo `INTEGER`, auto-incrementada.
- **DataPedido**: Tipo `DATE`, armazena a data do pedido.
- **ValorTotal**: Tipo `DECIMAL`, armazena o valor total do pedido.
- **ClienteID**: Chave estrangeira do tipo `INTEGER`, que faz referência ao campo `ID` da tabela **Clientes**.

### 3. Inserção de Dados

Após a criação das tabelas, foram inseridos dados nas tabelas **Clientes** e **Pedidos** com os seguintes requisitos:

- Inserir pelo menos 3 clientes na tabela **Clientes**.
- Inserir pelo menos 2 pedidos na tabela **Pedidos**, associando-os corretamente aos clientes.

### 4. Consultas SQL

Foram realizadas as seguintes consultas SQL:

- **Seleção de todos os campos** da tabela **Clientes**.
- **Seleção de apenas o nome e email** dos clientes.
- **Seleção de todos os campos** da tabela **Pedidos**, filtrando pedidos com valor maior que um determinado valor.

### 5. Atualização e Exclusão de Dados

Realizamos as seguintes operações de manipulação de dados:

- Atualização do email de um cliente específico.
- Atualização do valor total de um pedido.
- Exclusão de um pedido específico.

### 6. Filtragem e Ordenação de Dados

Foram feitas consultas utilizando as cláusulas `WHERE` e `ORDER BY` para filtrar e ordenar os dados:

- **Filtrar clientes** que moram em uma cidade específica.
- **Filtrar pedidos** com valor maior que um valor determinado.
- **Ordenar clientes por nome** em ordem alfabética.
- **Ordenar pedidos** por valor total, do maior para o menor.

### 7. Junções de Tabelas

Foram realizadas consultas com as junções `INNER JOIN` e `LEFT JOIN`:

- **INNER JOIN** entre as tabelas **Clientes** e **Pedidos**, retornando o nome do cliente e o valor total de cada pedido.
- **LEFT JOIN** entre as tabelas **Clientes** e **Pedidos**, retornando todos os clientes, juntamente com os pedidos associados, se existirem.

