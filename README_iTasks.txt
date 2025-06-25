iTasks – Projeto Final da UC de Desenvolvimento de Aplicações
=============================================================

Grupo de Trabalho:
------------------
- [Preencher nome e número de aluno]
- [Preencher nome e número de aluno]
- [Preencher nome e número de aluno]

Resumo do Projeto:
------------------
A aplicação iTasks é um sistema de gestão de tarefas orientado ao método Kanban, destinado a programadores e gestores de uma organização. 
Permite a criação, atribuição e acompanhamento de tarefas com base em estados (ToDo, Doing, Done), com funcionalidades adaptadas ao tipo de utilizador autenticado.

Principais Funcionalidades:
---------------------------
- Login de utilizadores (Gestor e Programador)
- Listas Kanban com arrastamento de tarefas por estado
- Gestão de utilizadores (CRUD) – apenas para Gestores
- Gestão de tipos de tarefa (CRUD) – apenas para Gestores
- Consulta de tarefas em curso e concluídas com filtros
- Visualização e edição de tarefas conforme permissões
- Exportação de tarefas para CSV (Gestor)
- Estimativa de tempo com base em Story Points
- Envio de email ao concluir tarefa (Done)
- Filtros por Projeto e estatísticas por Projeto (Adenda)

Tecnologias Usadas:
-------------------
- Linguagem: C#
- Framework: .NET Framework 4.8
- Interface: Windows Forms
- ORM: Entity Framework (Code First)
- Base de Dados: SQL Server (LocalDB)

Instalação e Execução:
----------------------
1. Abrir o ficheiro da solução (.sln) com o Visual Studio 2022 ou superior
2. Compilar o projeto (Build)
3. Executar a aplicação (F5)
4. A base de dados será gerada automaticamente via Entity Framework (migrations já incluídas)
5. Usar o formulário de login para aceder à aplicação (preencher utilizadores manualmente na base de dados ou inserir seed de teste)

Notas:
------
- A aplicação implementa todas as funcionalidades obrigatórias da avaliação periódica e da adenda da época normal.
- O projeto encontra-se estruturado segundo uma abordagem modular, respeitando o padrão MVC na organização geral.
- Foram efetuados testes manuais aos principais fluxos de utilização.