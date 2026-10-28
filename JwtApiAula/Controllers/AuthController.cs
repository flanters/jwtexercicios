using JwtApi.Models;
using JwtApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace JwtApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        private const string UsuarioFixo = "admin";
        private const string SenhaFixa = "123456";

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            if (request.Usuario == UsuarioFixo &&
                request.Senha == SenhaFixa)
            {
                var token = _tokenService.GenerateToken(
                    request.Usuario);

                return Ok(new
                {
                    token
                });
            }

            return Unauthorized(new
            {
                mensagem = "Usuário ou senha inválidos."
            });
        }
    }
}