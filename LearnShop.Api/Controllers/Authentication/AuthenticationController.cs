using LearnShop.Api.Database;
using LearnShop.Api.Database.Models;
using LearnShop.Api.DataTransfer.Auth;
using LearnShop.Api.Helper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Net;
using System.Security.Claims;

namespace LearnShop.Api.Controllers.Authentication;

[Route("api/Auth")]
[ApiController]
[AllowAnonymous]
public class AuthenticationController : ControllerBase
{
    public DatabaseContext DbContext { get; init; }

    public AuthenticationController(DatabaseContext dbContext)
    {
        DbContext = dbContext;
    }

    [HttpPost("login")]
    public async Task LoginAsync([FromBody] UserData payload)
    {
        using MySqlDataReader reader = await DbContext.ExecuteQueryAsync(
            $"SELECT * FROM {TableNames.Account} WHERE username='{payload.Username}';");

        reader.Read();
        Account account = Account.FromDatabase(reader);

        string hash = HashHelper.ToSha512Hash(payload.Password);

        if (hash != account.Password)
        {
            HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            return;
        }

        await HttpContext.SignInAsync(
            BearerTokenDefaults.AuthenticationScheme, 
            CreatePrincipal(account.AccountId, account.Username));
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync([FromBody] UserData payload)
    {
        return Ok();
    }

    private static ClaimsPrincipal CreatePrincipal(int id, string name)
    {
        return new ClaimsPrincipal(new List<ClaimsIdentity>()
        {
            new ClaimsIdentity(new List<Claim>()
            {
                new Claim(ClaimTypes.Sid, id.ToString()),
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Role, "User")
            })
        });
    }
}
