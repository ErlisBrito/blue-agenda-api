using blue_agenda_api.Application.Interfaces;
using blue_agenda_api.Application.ViewModels;
using blue_agenda_api.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace blue_agenda_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly ILogger<ContatoController> _logger;
        private readonly IContatoAppService _contatoAppService;
        public ContatoController(ILogger<ContatoController> logger, IContatoAppService contatoAppService )
        {
            _logger = logger;
            _contatoAppService = contatoAppService;
        }

        [HttpPost("CriaContato")]
        public async  Task<IActionResult> CriaContato(PessoaContatoViewModel pessoaContato)
        {
            var result = await _contatoAppService.CriaContatoAsync(pessoaContato);
            return Ok (result);  
        }

        [HttpGet("ObterContato")]
        public async Task<IActionResult> ObterContato(Guid idContato)
        {
            var result = await _contatoAppService.ObterContatoAsync(idContato);
            return Ok(result);
        }

        [HttpPut("EditarContato")]
        public async Task<IActionResult> EditarContato(PessoaContatoViewModel pessoaContato)
        {
            var result = await _contatoAppService.EditarContatoAsync(pessoaContato);
            return Ok(result);
        }

        [HttpDelete("DeletarContato")]
        public async Task<IActionResult> DeletarContato(Guid idContato)
        {
            var result = await _contatoAppService.ObterContatoAsync(idContato);
            return Ok(result);
        }

    }
}
