
// Controllers/CategoriasController.cs
using Microsoft.AspNetCore.Mvc;
using EstoqueAPI.Models;

namespace EstoqueAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var categorias = Categorias.ListarCategorias();
            return Ok(categorias);
        }
    }
}
