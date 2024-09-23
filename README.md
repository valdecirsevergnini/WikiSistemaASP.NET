
=======
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
>>>>>>> 9b25a6d5bc7cfdf77b7090f50df4ca05c5f912ad
<<<<<<< HEAD
WikiSistemaASP.NET
Este é um projeto de Wiki desenvolvido em C# e ASP.NET Core, utilizando PostgreSQL como banco de dados.

Funcionalidades
Sistema de autenticação.
Criação, edição e busca por tópicos dentro da Wiki.
Documentação organizada em módulos.
Conexão com PostgreSQL.
Requisitos
.NET SDK 6.0 ou superior
PostgreSQL (Recomendado: pgAdmin para administração)
Ferramentas Git para versionamento.
Instalação do Ambiente
1. Clonar o Repositório
Para clonar o repositório em sua máquina local, use o comando abaixo:

bash
Copiar código
git clone https://github.com/valdecirsevergnini/WikiSistemaASP.NET.git
cd WikiSistemaASP.NET
2. Instalar Dependências
Certifique-se de estar no diretório do projeto. Instale as dependências do projeto utilizando os comandos abaixo:

bash
dotnet restore
3. Configurar o Banco de Dados
Você deve configurar o PostgreSQL como o banco de dados do projeto.

Criar o banco de dados no PostgreSQL:

Acesse o pgAdmin e crie um banco de dados chamado wikidb.

Configurar a string de conexão:

No arquivo appsettings.json, substitua as credenciais da string de conexão para refletir sua configuração local:

json

{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=wikidb;Username=postgres;Password=3830"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
4. Configuração do Ambiente de Desenvolvimento
Se precisar de configurações específicas para o ambiente de desenvolvimento, edite o arquivo appsettings.Development.json.

5. Executar as Migrações do Banco de Dados
Com o banco configurado e a string de conexão correta, execute as migrações para criar as tabelas no PostgreSQL:

bash
dotnet ef database update
Certifique-se de que você tenha instalado a ferramenta dotnet-ef. Caso contrário, execute:

bash
dotnet tool install --global dotnet-ef
6. Rodar o Projeto
Para rodar o projeto, utilize o comando:

bash
Copiar código
dotnet run
O projeto estará acessível via https://localhost:5050 ou http://localhost:5050.

Estrutura do Projeto
Controllers: Contém os controladores responsáveis pelas ações do sistema.
Models: Contém as classes de modelo que representam as entidades do sistema.
Views: Contém as páginas que serão renderizadas para o usuário final.
wwwroot: Diretório de arquivos estáticos como CSS, JS e imagens.
appsettings.json: Configurações de ambiente e banco de dados.
Contribuindo
Siga o passo a passo acima para configurar o ambiente local. Ao fazer alterações no código:

Crie uma nova branch:

bash
git checkout -b sua-branch
Faça suas modificações.

Commit e push das mudanças:

bash
git add .
git commit -m "Descrição do que foi alterado"
git push origin sua-branch
Abra um pull request para revisão.
