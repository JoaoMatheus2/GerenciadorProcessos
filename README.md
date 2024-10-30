# Sistema de Gerenciamento de Processos

Este sistema foi desenvolvido utilizando **.NET 7**, **ASP.NET Core** e **Entity Framework**, com o objetivo de facilitar o gerenciamento de processos. Ele permite realizar operações de cadastro, edição, detalhamento e exclusão de processos, além de listar todos os processos cadastrados. O sistema também conta com uma integração para consulta de municípios por meio da **API do IBGE**.

## Funcionalidades

- **Listar Processos**: Exibe uma lista de todos os processos cadastrados em uma tabela.
- **Editar Processos**: Permite modificar os dados de um processo existente.
- **Detalhar Processos**: Apresenta os detalhes completos de um processo específico.
- **Excluir Processos**: Remove um processo do sistema de forma permanente.
- **Consulta de Municípios**: Integração com a API do IBGE para listar os municípios com base no estado (UF) selecionado.

## Tecnologias Utilizadas

- **.NET 7**
- **ASP.NET Core**
- **Entity Framework**
- **SQL Server**
- **API do IBGE**: Usada para consulta de municípios com base no estado selecionado.

## Configuração do Banco de Dados

O projeto utiliza o **Entity Framework** para gerenciar o banco de dados. As migrations já estão configuradas para criar as tabelas necessárias no banco.

### Passos para Configurar e Executar a Migration

1. **Configuração da String de Conexão**:

   No arquivo `appsettings.json`, configure a string de conexão com seu banco de dados SQL Server na seção `ConnectionStrings`:

   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=SEU_SERVIDOR;Database=NOME_DO_BANCO;Trusted_Connection=True;"
   }

## Pré-requisitos

Antes de começar, certifique-se de ter os seguintes itens instalados em seu sistema:

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (com suporte para ASP.NET)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (ou outro gerenciador de banco de dados de sua escolha)


