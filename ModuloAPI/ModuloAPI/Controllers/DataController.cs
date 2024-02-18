using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("controller")]
    public class DataController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHoraAtual()
        {
            var obj = new
            {
                data = DateTime.Now.ToLongDateString(),
                hora = DateTime.Now.ToShortTimeString(),
            };

            return Ok(obj);
        }

        [HttpGet("ObterData5AnosDepois")]
        public IActionResult ObterDataCincoAnosDepois()
        {
            var obj = new
            { 
                data = DateTime.Now.AddYears(5).ToLongDateString()            
            };

            return Ok(obj);
        }
    }
}
