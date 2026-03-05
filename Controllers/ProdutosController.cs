
// Controllers/ProdutosController.cs
using Microsoft.AspNetCore.Mvc;
using EstoqueAPI.Models;
using EstoqueAPI.Repositories;

namespace EstoqueAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        // GET: api/produtos
        [HttpGet]
        public IActionResult GetAll()
        {
            var produtos = _produtoRepository.GetAll();
            return Ok(produtos);
        }

        // GET: api/produtos/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var produto = _produtoRepository.GetById(id);
            if (produto == null)
                return NotFound($"Produto com ID {id} não encontrado.");
            
            return Ok(produto);
        }

        // GET: api/produtos/categoria/{categoria}
        [HttpGet("categoria/{categoria}")]
        public IActionResult GetByCategoria(string categoria)
        {
            var produtos = _produtoRepository.GetByCategoria(categoria);
            return Ok(produtos);
        }

        // POST: api/produtos
        [HttpPost]
        public IActionResult Create([FromBody] Produto produto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var novoProduto = _produtoRepository.Add(produto);
            return CreatedAtAction(nameof(GetById), new { id = novoProduto.Id }, novoProduto);
        }

        // PUT: api/produtos/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Produto produto)
        {
            if (id != produto.Id)
                return BadRequest("ID da URL não corresponde ao ID do produto.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingProduto = _produtoRepository.GetById(id);
            if (existingProduto == null)
                return NotFound($"Produto com ID {id} não encontrado.");

            var updatedProduto = _produtoRepository.Update(produto);
            return Ok(updatedProduto);
        }

        // DELETE: api/produtos/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var produto = _produtoRepository.GetById(id);
            if (produto == null)
                return NotFound($"Produto com ID {id} não encontrado.");

            _produtoRepository.Delete(id);
            return NoContent();
        }

        // PATCH: api/produtos/{id}/estoque
        [HttpPatch("{id}/estoque")]
        public IActionResult AtualizarEstoque(int id, [FromBody] int quantidade)
        {
            var produto = _produtoRepository.GetById(id);
            if (produto == null)
                return NotFound($"Produto com ID {id} não encontrado.");

            produto.QuantidadeEstoque += quantidade;
            _produtoRepository.Update(produto);
            
            return Ok(produto);
        }
    }
}
