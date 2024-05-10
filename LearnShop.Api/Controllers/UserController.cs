using LearnShop.Api.Database;
using Microsoft.AspNetCore.Mvc;

namespace LearnShop.Api.Controllers;

public class AccountController : BaseController
{
    public AccountController(DatabaseContext dbContext) : base(dbContext)
    {

    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("{\"name\": \"test\"}");
    }

    [HttpPost]
    public async Task<IActionResult> Update()
    {
        
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {

    }
}
