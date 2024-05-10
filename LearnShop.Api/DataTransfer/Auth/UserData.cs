using System.ComponentModel.DataAnnotations;

namespace LearnShop.Api.DataTransfer.Auth;

public class UserData
{
    [MaxLength(200)]
    public string Username { get; set; }

    public string Password { get; set; }
}
