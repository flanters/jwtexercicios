using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [Authorize]
        [HttpGet("perfil")]
        public IActionResult Perfil()
        {
            var usuario = User.Identity?.Name;

            return Ok(new
            {
                mensagem = $"Olá {usuario}, acesso autorizado!"
            });
        }
    }
}