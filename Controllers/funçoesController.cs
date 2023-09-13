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

        [HttpGet("NumeroAleatorio/{menorValor}/{maiorValor}/{quantidadeValores}")]
        public IActionResult GerarNumeroAleatorio(int menorValor, int maiorValor, int quantidadeValores = 1)
        {
            Random aleatorio = new Random();
            int[] numero = new int[quantidadeValores];
            for (int i = 0; i < quantidadeValores; i++)
            {
                numero[i] = aleatorio.Next(menorValor, maiorValor);
            }

            return Ok(new { numero });
        }
    }
}