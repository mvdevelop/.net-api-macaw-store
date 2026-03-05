
## API de Estoque - Loja de Eletrodomésticos e Eletrônicos
https://img.shields.io/badge/.NET-8.0-purple
https://img.shields.io/badge/license-MIT-blue

API RESTful desenvolvida em C# com padrão MVC para gerenciamento de estoque de uma loja de eletrodomésticos e eletrônicos. Permite operações completas de CRUD para produtos, consultas por categoria e controle de estoque.

## 📋 Índice
Tecnologias Utilizadas

Estrutura do Projeto

Pré-requisitos

Instalação e Execução

Endpoints da API

Exemplos de Uso

Modelo de Dados

Categorias Disponíveis

Contribuição

Licença

## 🚀 Tecnologias Utilizadas
.NET 8.0 - Framework principal

ASP.NET Core - Criação da API

Swagger/OpenAPI - Documentação e testes

Programação em Memória - Repositório simulando banco de dados

## 📁 Estrutura do Projeto
text
EstoqueAPI/
├── Controllers/
│   ├── ProdutosController.cs     # Controle de produtos
│   └── CategoriasController.cs    # Controle de categorias
├── Models/
│   ├── Produto.cs                 # Modelo de produto
│   └── Categoria.cs               # Constantes e lista de categorias
├── Repositories/
│   ├── IProdutoRepository.cs       # Interface do repositório
│   └── ProdutoRepository.cs        # Implementação do repositório
├── Program.cs                      # Configuração da aplicação
└── EstoqueAPI.csproj               # Arquivo de projeto

## ⚙️ Pré-requisitos
.NET 8.0 SDK

Git (opcional, para clonar o repositório)

Visual Studio Code ou Visual Studio 2022 (opcional)

## 🔧 Instalação e Execução
1. Clone o repositório
bash
git clone https://github.com/seu-usuario/estoque-api.git
cd estoque-api
2. Execute a aplicação
bash
dotnet restore
dotnet run
3. Acesse a documentação Swagger
Abra o navegador e acesse:

text
https://localhost:5001/swagger

## 📌 Endpoints da API
Produtos
Método	Endpoint	Descrição
GET	/api/produtos	Lista todos os produtos
GET	/api/produtos/{id}	Busca produto por ID
GET	/api/produtos/categoria/{categoria}	Lista produtos por categoria
POST	/api/produtos	Cria um novo produto
PUT	/api/produtos/{id}	Atualiza um produto existente
DELETE	/api/produtos/{id}	Remove um produto
PATCH	/api/produtos/{id}/estoque	Atualiza quantidade em estoque
Categorias
Método	Endpoint	Descrição
GET	/api/categorias	Lista todas as categorias disponíveis

## 📝 Exemplos de Uso
Criar um novo produto
json
POST /api/produtos
{
  "nome": "Geladeira Frost Free",
  "descricao": "Geladeira 400L com tecnologia frost free",
  "categoria": "Geladeira",
  "preco": 3500.00,
  "quantidadeEstoque": 10,
  "marca": "Electrolux",
  "modelo": "TF40"
}
Atualizar estoque
json
PATCH /api/produtos/1/estoque
Corpo da requisição: 5
Adiciona 5 unidades ao estoque (use números negativos para remover)

Buscar produtos por categoria
text
GET /api/produtos/categoria/Smartphone

## 💾 Modelo de Dados
Produto
Campo	Tipo	Descrição
Id	int	Identificador único
Nome	string	Nome do produto
Descricao	string	Descrição detalhada
Categoria	string	Categoria do produto
Preco	decimal	Preço de venda
QuantidadeEstoque	int	Quantidade em estoque
Marca	string	Marca do produto
Modelo	string	Modelo específico
DataCadastro	DateTime	Data de inclusão

## 🏷️ Categorias Disponíveis
Geladeira

Fogão

Microondas

Televisão

Smartphone

Notebook

Tablet

Áudio

Vídeo

## 🤝 Contribuição
Faça um fork do projeto

Crie uma branch para sua feature (git checkout -b feature/AmazingFeature)

Commit suas mudanças (git commit -m 'Add some AmazingFeature')

Push para a branch (git push origin feature/AmazingFeature)

Abra um Pull Request

## 📄 Licença
Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

## ✨ Funcionalidades Futuras
Autenticação JWT

Relatórios de movimentação de estoque

Histórico de alterações de preço

Alertas de estoque baixo

Integração com banco de dados real (SQL Server/PostgreSQL)

Testes unitários e de integração
