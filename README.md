# WikiSistemaASP.NET

Este é um projeto de uma Wiki para documentar um sistema desenvolvido em **C#** e **ASP.NET Core**. A Wiki permite que usuários autenticados adicionem e atualizem conteúdo, incluindo textos, imagens e vídeos. Usuários não autenticados podem visualizar o conteúdo. A Wiki possui suporte para busca por palavras-chave e navegação por módulos e tópicos.

## Visão Geral

O objetivo deste projeto é criar uma Wiki organizada e intuitiva para facilitar a documentação de um sistema ASP.NET. Ela permitirá a criação e edição de conteúdo dividido em módulos, facilitando a busca e o acesso a diferentes tópicos. 

Usuários com permissões de administrador poderão adicionar, editar ou excluir conteúdos como textos, imagens e vídeos. Visitantes não autenticados poderão apenas visualizar o conteúdo.

## Funcionalidades

1. **Autenticação e Autorização**
   - Controle de login e senha para acesso ao painel de administração.
   - Controle de acesso baseado em permissões: visitantes podem visualizar, administradores podem editar o conteúdo.

2. **Gerenciamento de Conteúdo**
   - Inserção e formatação de textos com suporte a Markdown ou HTML.
   - Upload de imagens e vídeos para serem inseridos no conteúdo.
   - Organização do conteúdo por módulos e tópicos para facilitar a navegação.

3. **Busca e Navegação**
   - Busca por palavras-chave para encontrar documentos e conteúdos relevantes.
   - Menu de navegação entre módulos e tópicos, com a possibilidade de expandir e contrair seções.

## Tecnologias Utilizadas

- **Backend**: C# e ASP.NET Core
- **Frontend**: HTML, CSS, JavaScript (opcionalmente com frameworks como React ou Angular)
- **Banco de Dados**: PostgreSQL
- **Armazenamento de Arquivos**: Sistema de arquivos local ou serviço de armazenamento na nuvem (ex: AWS S3)

## Estrutura do Projeto

A estrutura do projeto é organizada da seguinte maneira:

- `/Controllers` - Controladores ASP.NET Core para lidar com solicitações HTTP.
- `/Models` - Modelos de dados para a Wiki.
- `/Views` - Views Razor para renderização das páginas.
- `/wwwroot` - Arquivos estáticos (CSS, JS, imagens).
- `/Data` - Contexto do banco de dados e migrações.
- `/Services` - Serviços de lógica de negócios.

## Requisitos de Instalação

Antes de começar, certifique-se de ter as seguintes ferramentas instaladas em seu sistema:

- [.NET Core SDK 6.0 ou superior](https://dotnet.microsoft.com/download/dotnet/6.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Git](https://git-scm.com/)

## Passos para Instalação

### 1. Clonar o Repositório

No terminal ou Git Bash, clone o repositório:

```bash
git clone https://github.com/seu-usuario/WikiSistemaASP.NET.git
cd WikiSistemaASP.NET/WikiSistema
