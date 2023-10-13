using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ModuloAPI.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]

    public class UsuarioController : ControllerBase
    {

        [HttpGet("datahora")]
        public IActionResult ObterDataHora()
        {
            var dataHora = new
            {
                Data = DateTime.Now.ToShortDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(dataHora);
        }
    }
}
