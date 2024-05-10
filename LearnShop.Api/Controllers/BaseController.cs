using LearnShop.Api.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LearnShop.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "User")]
public class BaseController : ControllerBase
{
    public DatabaseContext DbContext { get; init; }

    public BaseController(DatabaseContext dbContext)
    {
        DbContext = dbContext;
    }
}
