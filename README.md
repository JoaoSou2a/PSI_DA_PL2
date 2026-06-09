# PSI_DA_PL2
Projeto de Desenvolvimento de Aplicações iShopping
--------------------------------------------------------------------

# Índice
1. Visão Geral
2. Requisitos do Sistema
3. Instruções de Instalação
4. Execução da Aplicação
5. Configuração
6. Elementos do Grupo
7. Suporte e Contato

--------------------------------------------------------------------

# 1. Visão Geral
- O iShopping é um programa de gestão de compras domésticas.
- Fornece uma solução completa para gerir o orçamento familiar, planear compras e registar artigos adquiridos.
- Com o iShopping, os membros do agregado familiar podem planear listas de compras, registar itens previstos e não previstos, controlar os valores gastos e gerir o orçamento mensal disponível.
- O objetivo do iShopping é simplificar a gestão das compras do dia a dia e ajudar as famílias a controlar melhor as suas despesas.
- O programa permite ainda exportar os dados para CSV e consultar estatísticas detalhadas sobre os gastos e orçamentos dos meses anteriores.

--------------------------------------------------------------------

# 2. Requisitos do Sistema
- Sistema Operativo: Windows
- .NET Framework 4.7.2 ou superior
- Visual Studio 2022
- SQL Server (LocalDB ou superior)
- 4 GB de RAM (mínimo)
- 100 MB de espaço disponível em disco

--------------------------------------------------------------------

# 3. Instruções de Instalação
- Fazer o download ou clonar o repositório do projeto.
- Descompactar o arquivo numa pasta à escolha.
- Abrir o projeto no Visual Studio 2022.
- Verificar a string de ligação à base de dados no ficheiro App.config.
- Compilar o projeto para restaurar os pacotes NuGet necessários.

--------------------------------------------------------------------

# 4. Execução da Aplicação
- Navegue até à pasta onde o projeto foi extraído.
- Dê duplo clique no ficheiro Projeto_DA.sln ou abra o projeto dentro do Visual Studio 2022:
  - Barra de opções (em cima) -> Arquivo -> Abrir -> Projeto/Solução
- Compile e execute o projeto premindo F5 ou clicando em "Iniciar".

--------------------------------------------------------------------

# 5. Configuração

## 5.1 Configuração Inicial
- Ao iniciar o programa será apresentado o ecrã de Login.
- Utilize as credenciais de um utilizador existente para aceder à aplicação
- Após o login, terá acesso ao menu principal com todas as funcionalidades disponíveis.

--------------------------------------------------------------------

## 5.2 Configuração da Base de Dados
Ao iniciar o programa é necessário verificar se a base de dados está conectada através do seguinte passo a passo:
- Barra de opções (em cima) -> Exibir -> Pesquisador de Objetos do SQL Server
- Se não aparecer nada -> Atualizar
- Se continuar a não aparecer nada -> É necessário reabrir o projeto iShopping
- A string de ligação pode ser configurada no ficheiro App.config, na chave "IShoppingContext".

--------------------------------------------------------------------

# 6. Elementos do Grupo
Realizado por:
- David Correia Santos       — 2025187687
- Gustavo da Mota Fernandes  — 2025187758
- João Botelho de Sousa      — 2023137435

--------------------------------------------------------------------

# 7. Suporte e Contato
- Para suporte técnico ou questões relacionadas à utilização do programa iShopping,
  entre em contato através do número de aluno de qualquer um dos elementos do grupo.
