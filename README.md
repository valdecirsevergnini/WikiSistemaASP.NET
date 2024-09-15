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
O projeto estará acessível via https://localhost:5001 ou http://localhost:5000.

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


