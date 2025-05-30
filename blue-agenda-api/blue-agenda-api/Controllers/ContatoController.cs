using Microsoft.AspNetCore.Mvc;

namespace blue_agenda_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        [HttpPost("CriaContato")]
        public IActionResult CriaContato()
        {
            return default(IActionResult);  
        }

        [HttpGet("ObterContato")]
        public IActionResult ObterContato()
        {
            return default(IActionResult);
        }

        [HttpPut("EditarContato")]
        public IActionResult EditarContato()
        {
            return default(IActionResult);
        }

        [HttpDelete("DeletarContato")]
        public IActionResult DeletarContato()
        {
            return default(IActionResult);
        }

    }
}
