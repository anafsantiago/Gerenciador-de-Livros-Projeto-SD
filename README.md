
![Logo Gerenciador de Livros](https://github.com/anafsantiago/Gerenciador-de-Livros-Projeto-SD/assets/87740921/bcf497a4-9b95-4a67-82b5-5031e47fd6fd)

## Índice
* [Imagem de capa](#Imagem-de-capa)
* [Índice](#índice)
* [Descrição do Projeto](#descrição-do-projeto)
* [Funcionalidades e Demonstração da Aplicação](#funcionalidades-e-demonstração-da-aplicação)
* [Tecnologias utilizadas](#tecnologias-utilizadas)
* [Configuração e Execução do projeto](#configuracao-e-execucao)
* [Dependências](#dependencias)
* [Desenvolvedores do Projeto](#desenvolvedores)

## Descrição do projeto Gerenciador de Livros
Este projeto foi desenvolvido para compor a avaliação A3 na disciplina de Sistemas Distribuídos e Mobile do curso de Sistemas de Informação. Trata-se de um sistema de gerenciamento de livros que permite aos usuários administrarem os seus acervos individuais, oferencendo funcionalidades para adicionar, atualizar, excluir e buscar livros, de modo a possibilitar que os usuários tenham maior controle sobre os seus acervos. Para isso, o Gerenciador de Livros, desenvolvido por meio da linguagem C# e do framework .NET, integra-se à API do Google Books para enriquecer as informações a respeito dos livros e realiza operações de CRUD em um banco de dados local MongoDB.

## Funcionalidades
* Adiciona novos livros ao banco de dados MongoDB.
* Atualiza livros já existentes no banco de dados MongoDB.
* Exclui livros do banco de dados MongoDB.
* Busca, por ISBN, por título ou por autor, os livros armazenados no banco de dados MongoDB. 
* Lista os livros armazenados no banco de dados MongoDB.
* Integra-se à API do Google Books para consumir as informações sobre os livros presentes no banco de dados do sistema.

## Demonstração da aplicação
### Página Inicial
A página Inicial permite que o usuário escolha entre as opções de pesquisar, adicionar ou excluir livros no sistema Gerenciador de Livros.

![Pagina Inicial - Gerenciador de Livros](https://github.com/anafsantiago/Gerenciador-de-Livros-Projeto-SD/assets/87740921/5d86805a-918f-455c-ba55-bbc3634863b8)

### Página Adicionar
A página Adicionar permite que o usuário adicione um novo livro no banco de dados por meio do código ISBN. Caso o ISBN informado já esteja presente no banco de dados, as informações daquele livro serão atualizadas. Essas informações são originadas a partir da integração entre o sistema Gerenciador de Livros e a API do Google Books, que armazena milhares de obras.

![Pagina Adicionar - Gerenciador de Livros](https://github.com/anafsantiago/Gerenciador-de-Livros-Projeto-SD/assets/87740921/3f00b8a4-ce1e-442d-8e8e-952c1a93af3b)

### Página Excluir
A página Excluir permite que o usuário exclua o registro de um livro do banco de dados por meio do código ISBN.

![Pagina Excluir - Gerenciador de Livros](https://github.com/anafsantiago/Gerenciador-de-Livros-Projeto-SD/assets/87740921/c247743e-7793-4eff-9dbe-026fd0fe48a8)

### Página Buscar
A página Buscar permite que o usuário pesquise se há determinado livro no banco de dados e retorna as informações referentes aos livros encontrados. Essa busca pode ser realizada por meio do código ISBN, do título ou do nome do autor.

![Pagina Buscar - Gerenciador de Livros](https://github.com/anafsantiago/Gerenciador-de-Livros-Projeto-SD/assets/87740921/c4f5adbe-14bb-4937-a18c-e2078cc65282)

## Tecnologias utilizadas
* C#
* .NET
* MongoDB
* API do Google Books

## Configuração
Certifique-se de ter o .NET 4.8 e o MongoDB instalados na sua máquina.

### Execução do projeto
* Clone este repositório para a sua máquina local
* Abra o projeto no Visual Studio
* Execute o projeto

## Dependências
Certifique-se de ter as seguintes dependências instaladas:
* Newtonsoft.Json
* MongoDB.Driver
* MongoDB.Bson

## Desenvolvedores
Ana Flávia Santiago e Roberto Nascimento 
