using ControleDeFinanças.Data.Repository.Receita;
using ControleDeFinanças.Enums;
using ControleDeFinanças.Services.ReceitaService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ControleDeFinanças.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitaController : ControllerBase
    {
        private readonly IReceitaService _receitaService;

        public ReceitaController(IReceitaService receitaService)
        {
            _receitaService = receitaService;
        }

        [HttpPost]
        public IActionResult AdicionarReceita(double valorReceita, MesEnum mesDeRegistro, int anoDeRegistro) 
        {
            _receitaService.AdicionarReceita( valorReceita, mesDeRegistro, anoDeRegistro);

           return Ok();

        }

        [HttpGet]
        public string BuscarReceitaMensal(MesEnum mesDeRegistro, int anoDeRegistro)
        {
            var retornoGetReceita = _receitaService.BuscarReceitaMensal(mesDeRegistro, anoDeRegistro);

            return retornoGetReceita;
        }
    }
}
