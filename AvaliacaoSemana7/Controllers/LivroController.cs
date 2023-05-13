using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoSemana7.Controllers
{
    public class LivroController : Controller
    {
        private readonly Livro _livro;

        public LivroController()
        {
            _livro = new Livro();
        }

        [HttpPost("InserirLivro")]
        public IActionResult InserirLivro([FromBody] Livro livro)
        {
            try
            {
                _livro.InserirLivro(livro);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ObterLivroById/{id}")]
        public IActionResult ObterLivroById(int id)
        {
            try
            {
                Livro livro = _livro.ObterLivroById(id);
                if (livro != null)
                    return Ok(livro);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
