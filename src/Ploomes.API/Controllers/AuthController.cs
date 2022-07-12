using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Ploomes.API.Token;
using Ploomes.API.Utilities;
using Ploomes.API.ViewModels;
using Ploomes.API.ViewModes;
using System;

namespace Ploomes.API.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ITokenGenerator _tokenGenerator;

        public AuthController(IConfiguration configuration, ITokenGenerator tokenGenerator)
        {
            _configuration = configuration;
            _tokenGenerator = tokenGenerator;
        }

        /// <summary>
        /// Login de email e senha
        /// </summary>
        /// <param name="loginViewModel"></param>
        /// <returns>Retorna Token de autenticação</returns>
        [HttpPost]
        [Route("/api/v1/auth/login")]
        public IActionResult Login([FromBody] LoginViewModel loginViewModel)
        {

            // Login e senha fixos no appsettings.json
            var tokenLogin = _configuration["Jwt:Login"];
            var tokenPassword = _configuration["Jwt:Password"];

            // Verificação simples de login, 
            if (loginViewModel.Login == tokenLogin && loginViewModel.Password == tokenPassword)
                return Ok(new ResultViewModel
                {
                    Message = "Usuário autenticado com sucesso!",
                    Success = true,
                    Data = new
                    {
                        Token = _tokenGenerator.GenerateToken(),
                        TokenExpires = DateTime.UtcNow.AddHours(int.Parse(_configuration["Jwt:HoursToExpire"]))
                    }
                });
            else
                return StatusCode(401, Responses.UnauthorizedErrorMessage());
        }

    }
}
