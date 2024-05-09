using LearnShop.Api.Helper;

namespace LearnShop.Tests.Tests.Helper;

public class HashHelperShould
{
    [Theory]
    [InlineData("hello", "9b71d224bd62f3785d96d46ad3ea3d73319bfbc2890caadae2dff72519673ca72323c3d99ba5c11d7c7acc6e14b8c5da0c4663475c2e5c3adef46f73bcdec043")]
    [InlineData("Test", "c6ee9e33cf5c6715a1d148fd73f7318884b41adcb916021e2bc0e800a5c5dd97f5142178f6ae88c8fdd98e1afb0ce4c8d2c54b5f37b30b7da1997bb33b0b8a31")]
    [InlineData("Hashing input", "1be6043ff631fa8e83a1139cde7eb1cb10953ec1b63d5eb5b7179bae7b893144ee88a62121bc535cc41a85792ccb9d1dbc3cd20d6cb0b75718d49c6882ea549e")]
    public void GenerateExpectedSha512Hashes(string input, string expected)
    {
        string actual = HashHelper.ToSha512Hash(input);
        Assert.Equal(expected, actual); 
    }
}
