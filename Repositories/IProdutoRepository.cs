
// Repositories/IProdutoRepository.cs
using EstoqueAPI.Models;

namespace EstoqueAPI.Repositories
{
    public interface IProdutoRepository
    {
        List<Produto> GetAll();
        Produto GetById(int id);
        Produto Add(Produto produto);
        Produto Update(Produto produto);
        bool Delete(int id);
        List<Produto> GetByCategoria(string categoria);
    }
}
