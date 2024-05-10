using MySqlConnector;
using System.Text.Json;

namespace LearnShop.Api.Database;

internal struct DbCredentials
{
    public string User { get; set; }

    public string Password { get; set; }
}

public class DatabaseContext : IDisposable
{
    public MySqlConnection Connection { get; init; }

    public DatabaseContext()
    {
        DbCredentials creds = JsonSerializer.Deserialize<DbCredentials>(
            File.ReadAllText("secret.json"));

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = creds.User,
            Password = creds.Password,
            Database = "learnshop",
        };

        Connection = new MySqlConnection(builder.ConnectionString);

        Connection.Open();
    }

    public async Task<MySqlDataReader> ExecuteQueryAsync(string sql)
    {
        using MySqlCommand command = Connection.CreateCommand();

        command.CommandText = sql;

        return await command.ExecuteReaderAsync();
    }

    public async Task<int> ExecuteNonQuery(string sql)
    {
        using MySqlCommand command = Connection.CreateCommand();
        command.CommandText = sql;

        return await command.ExecuteNonQueryAsync();
    }

    public void Dispose()
    {
        Connection.Dispose();
    }
}
