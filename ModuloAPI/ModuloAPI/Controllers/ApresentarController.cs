using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
    public class ApresentarController : ControllerBase
    {
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem vindo!";
            return Ok(new { mensagem });
        }
    }
}