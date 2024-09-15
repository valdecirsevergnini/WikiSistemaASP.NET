WikiSistemaASP.NET

Este é um projeto de uma Wiki para documentar um sistema desenvolvido em C# e ASP.NET Core, utilizando PostgreSQL como banco de dados. A Wiki permite que usuários autenticados adicionem e atualizem conteúdo, enquanto visitantes podem visualizar as informações.

Funcionalidades
Autenticação e Autorização:

Controle de login e senha para acesso ao painel de administração.
Controle de permissões: visitantes podem visualizar o conteúdo, administradores podem editar.
Gerenciamento de Conteúdo:

Suporte para textos formatados em Markdown ou HTML.
Upload de imagens e vídeos para ilustrar o conteúdo.
Organização do conteúdo por módulos e tópicos, facilitando a navegação.
Busca e Navegação:

Busca por palavras-chave para encontrar documentos relevantes.
Navegação organizada em módulos e tópicos.
Tecnologias Utilizadas
Backend: C# e ASP.NET Core
Frontend: HTML, CSS, JavaScript
Banco de Dados: PostgreSQL
Armazenamento de Arquivos: Local ou serviço de armazenamento em nuvem (ex: AWS S3)
Estrutura do Projeto
Controllers: Controladores ASP.NET Core para lidar com solicitações HTTP.
Models: Modelos de dados que representam as entidades da Wiki.
Views: Views Razor para renderizar as páginas para o usuário.
wwwroot: Arquivos estáticos (CSS, JS, imagens).
Data: Contexto do banco de dados e migrações.
Services: Serviços de lógica de negócios.
Requisitos de Instalação
Certifique-se de ter as seguintes ferramentas instaladas no seu sistema:

.NET Core SDK 6.0 ou superior
PostgreSQL
Git
Passos para Configuração
1. Clonar o Repositório
No terminal ou Git Bash, clone o repositório:

bash

git clone https://github.com/valdecirsevergnini/WikiSistemaASP.NET.git
cd WikiSistemaASP.NET
2. Instalar Dependências
Dentro do diretório do projeto, execute:

bash

dotnet restore
3. Configurar o Banco de Dados
Crie o banco de dados no PostgreSQL:

Acesse o pgAdmin e crie um banco de dados chamado wikidb.
Configure a string de conexão:

No arquivo appsettings.json, insira suas credenciais do PostgreSQL:
json
Copiar código
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
4. Executar Migrações
Com o banco configurado, execute as migrações para criar as tabelas no PostgreSQL:

bash

dotnet ef database update
Se a ferramenta dotnet-ef não estiver instalada, instale-a com:

bash

dotnet tool install --global dotnet-ef
5. Rodar o Projeto
Para rodar o projeto, utilize:

bash

dotnet run
O projeto estará acessível em:

https://localhost:5001
http://localhost:5000
Contribuindo
Para contribuir com o projeto, siga os seguintes passos:

Crie uma nova branch para suas alterações:
bash

git checkout -b nome-da-branch
Faça as alterações e commit:
bash

git add .
git commit -m "Descrição das alterações"
Faça o push para o repositório remoto:
bash

git push origin nome-da-branch
Abra um Pull Request para revisão.

