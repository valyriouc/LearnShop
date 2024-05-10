using MySqlConnector;

namespace LearnShop.Api.Database.Models;

public interface IDatabaseModel<TEntity> where TEntity : class
{
    public abstract static TEntity FromDatabase(MySqlDataReader reader);
}

public class Account : IDatabaseModel<Account>
{
    public int AccountId { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public int PersonId { get; set; }

    public static Account FromDatabase(MySqlDataReader reader)
    {
        Account account = new Account();

        account.AccountId = reader.GetInt32("accountId");
        account.Username = reader.GetString("username");
        account.Password = reader.GetString("password");
        account.PersonId = reader.GetInt32("personId");

        return account;
    }
}
