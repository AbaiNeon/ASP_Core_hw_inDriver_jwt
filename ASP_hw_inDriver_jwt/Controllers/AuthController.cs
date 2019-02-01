using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_hw_inDriver_jwt.Models;
using ASP_hw_inDriver_jwt.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_hw_inDriver_jwt.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;

        public AuthController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Authenticate([FromBody] User user)
        {
            var token = await _userService.Authenticate(user.Login, user.Password);
            if (string.IsNullOrEmpty(token))
                return BadRequest();

            return Ok(new { token });
        }
    }
}