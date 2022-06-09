using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Circle.Models
{
    public interface IRegisterUser
    {
        public void Register(string username, string password, string firstName, string lastName);
    }
    public class RegisterUser : IRegisterUser
    {
        private readonly string _connectionString;
        
        public RegisterUser(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Register(string username, string password, string firstName, string lastName)
        {
            var query = "INSERT INTO dbo.Users(UserID, Username, Password, FirstName, LastName) " +
                        "VALUES(@USERID, @USERNAME, @PASSWORD, @FIRSTNAME, @LASTNAME)";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                var id = Guid.NewGuid();
                command.Parameters.AddWithValue("@USERID", id);
                command.Parameters.AddWithValue("@USERNAME", username);
                command.Parameters.AddWithValue("@PASSWORD", password);
                command.Parameters.AddWithValue("@FIRSTNAME", firstName);
                command.Parameters.AddWithValue("@LASTNAME", lastName);
                command.ExecuteNonQuery();
            }
        }
    }
}