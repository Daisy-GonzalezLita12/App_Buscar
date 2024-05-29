public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
}

public class UserService
{
    private readonly string _connectionString;

    public UserService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public bool Register(string username, string password)
    {
        var passwordHasher = new PasswordHasher<string>();
        var hashedPassword = passwordHasher.HashPassword(username, password);

        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand("INSERT INTO Users (Username, PasswordHash) VALUES (@username, @passwordHash)", connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@passwordHash", hashedPassword);
            var result = command.ExecuteNonQuery();
            return result > 0;
        }
    }

    public bool Login(string username, string password)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand("SELECT PasswordHash FROM Users WHERE Username = @username", connection);
            command.Parameters.AddWithValue("@username", username);

            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                var storedHash = reader.GetString(0);
                var passwordHasher = new PasswordHasher<string>();
                var result = passwordHasher.VerifyHashedPassword(username, storedHash, password);
                return result == PasswordVerificationResult.Success;
            }

            return false;
        }
    }
}
