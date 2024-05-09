using LearnShop.Api.DataTransfer.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LearnShop.Api.Controllers.Authentication;

[Route("api/Auth")]
[ApiController]
[AllowAnonymous]
public class AuthenticationController : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromBody] LoginData payload)
    {

    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync()
    {

    }
}
