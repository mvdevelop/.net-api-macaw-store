
// Models/Produto.cs
namespace EstoqueAPI.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
