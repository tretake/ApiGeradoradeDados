using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class FunçoesController : ControllerBase
    {

        [HttpGet("NumeroAleatorio/{menorValor}/{maiorValor}")]
        public IActionResult GerarNumeroAleatorio(int menorValor, int maiorValor)
        {
            Random aleatorio = new Random();
            int numero = aleatorio.Next(menorValor, maiorValor);
            return Ok(new { numero });
        }
    }
}