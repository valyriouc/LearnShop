using System.Security.Cryptography;
using System.Text;

namespace LearnShop.Api.Helper;

public static class HashHelper
{
    public static string ToSha512Hash(string input)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(input);
        byte[] output = SHA512.Create().ComputeHash(bytes);
        return BitConverter.ToString(output).Replace("-", string.Empty).ToLower();
    }
}
