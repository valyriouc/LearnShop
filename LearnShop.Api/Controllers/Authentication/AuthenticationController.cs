using LearnShop.Api.DataTransfer.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LearnShop.Api.Controllers.Authentication;

[Route("api/Auth")]
[ApiController]
[AllowAnonymous]
public class AuthenticationController : ControllerBase
{
    public AuthenticationController()
    {

    }

    [HttpPost("login")]
    public async Task LoginAsync([FromBody] UserData payload)
    {
        await HttpContext.SignInAsync(BearerTokenDefaults.AuthenticationScheme, CreatePrincipal());

    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync([FromBody] UserData payload)
    {
        return Ok();
    }

    private static ClaimsPrincipal CreatePrincipal()
    {
        return new ClaimsPrincipal(new List<ClaimsIdentity>()
        {
            new ClaimsIdentity(new List<Claim>()
            {
                new Claim(ClaimTypes.Email, "test@gmail.com")
            })
        });
    }
}
