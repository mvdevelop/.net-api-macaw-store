
// Repositories/ProdutoRepository.cs
using EstoqueAPI.Models;

namespace EstoqueAPI.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private static List<Produto> _produtos = new List<Produto>();
        private static int _nextId = 1;

        public ProdutoRepository()
        {
            // Adicionar alguns produtos de exemplo
            if (!_produtos.Any())
            {
                Add(new Produto
                {
                    Nome = "Geladeira Frost Free",
                    Descricao = "Geladeira 400L com tecnologia frost free",
                    Categoria = Categorias.Geladeira,
                    Preco = 3500.00m,
                    QuantidadeEstoque = 10,
                    Marca = "Electrolux",
                    Modelo = "TF40"
                });

                Add(new Produto
                {
                    Nome = "Smart TV 50",
                    Descricao = "Smart TV 4K 50 polegadas",
                    Categoria = Categorias.Televisao,
                    Preco = 2800.00m,
                    QuantidadeEstoque = 15,
                    Marca = "Samsung",
                    Modelo = "TU8000"
                });

                Add(new Produto
                {
                    Nome = "iPhone 13",
                    Descricao = "Smartphone Apple 128GB",
                    Categoria = Categorias.Smartphone,
                    Preco = 4500.00m,
                    QuantidadeEstoque = 8,
                    Marca = "Apple",
                    Modelo = "iPhone 13"
                });
            }
        }

        public List<Produto> GetAll()
        {
            return _produtos;
        }

        public Produto GetById(int id)
        {
            return _produtos.FirstOrDefault(p => p.Id == id);
        }

        public Produto Add(Produto produto)
        {
            produto.Id = _nextId++;
            produto.DataCadastro = DateTime.Now;
            _produtos.Add(produto);
            return produto;
        }

        public Produto Update(Produto produto)
        {
            var existingProduto = GetById(produto.Id);
            if (existingProduto != null)
            {
                existingProduto.Nome = produto.Nome;
                existingProduto.Descricao = produto.Descricao;
                existingProduto.Categoria = produto.Categoria;
                existingProduto.Preco = produto.Preco;
                existingProduto.QuantidadeEstoque = produto.QuantidadeEstoque;
                existingProduto.Marca = produto.Marca;
                existingProduto.Modelo = produto.Modelo;
            }
            return existingProduto;
        }

        public bool Delete(int id)
        {
            var produto = GetById(id);
            if (produto != null)
            {
                return _produtos.Remove(produto);
            }
            return false;
        }

        public List<Produto> GetByCategoria(string categoria)
        {
            return _produtos.Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
