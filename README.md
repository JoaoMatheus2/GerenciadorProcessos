# Sistema de Gerenciamento de Processos

Este é um sistema de gerenciamento de processos, desenvolvido utilizando .NET 7, ASP.NET Core e Entity Framework. O sistema permite realizar o cadastro, edição, detalhamento e exclusão de processos, além de listar todos os processos cadastrados.

## Funcionalidades

- **Listar Processos**: Exibe todos os processos cadastrados em uma tabela.
- **Editar Processos**: Permite editar os dados de um processo já existente.
- **Detalhar Processos**: Mostra os detalhes completos de um processo específico.
- **Excluir Processos**: Remove um processo do sistema.
- **Consulta de Municípios**: Integração com a API do IBGE para listar municípios de acordo com o estado selecionado.

## Tecnologias Utilizadas

- **.NET 7**
- **ASP.NET Core**
- **Entity Framework**
- **API do IBGE**: Utilizada para consulta de municípios com base no estado (UF).

## Configuração do Banco de Dados

Para a criação do banco de dados e das tabelas, foi utilizada a ferramenta de Migrations do Entity Framework. O projeto já inclui a migration responsável pela criação da estrutura do banco de dados.
