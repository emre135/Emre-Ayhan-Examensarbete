using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Circle.Models
{
    public interface IGetUser
    {
        public Task<User> VerifyUser(string username, string password);

        public Task<User> GetUserById(string id);

        public Task<User> GetUserByUsername(string username);
    }
    public class GetUser : IGetUser
    {
        private readonly string _connectionString;
        
        public GetUser(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<User> VerifyUser(string username, string password)
        {
            
            {
                
                    var query = "SELECT UserID, Username, Password, FirstName, LastName FROM dbo.Users WHERE Username = @USERNAME AND Password = @PASSWORD";

                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        var command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@USERNAME", username);
                        command.Parameters.AddWithValue("@PASSWORD", password);
                        var reader = await command.ExecuteReaderAsync();
                        var user = new User();
                        while (reader.Read())
                        { 
                        
                            user = new User()
                                {
                                    UserID = reader.GetString(reader.GetOrdinal("UserID")),
                                    Username = reader.GetString(reader.GetOrdinal("Username")),
                                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                    LastName = reader.GetString(reader.GetOrdinal("LastName"))
                                };
                            return user;
                        }

                        return user;


                    }
            }
            
        }

        public async Task<User> GetUserById(string id)
        {
            
                var query = "SELECT UserID, Username, FirstName, LastName FROM dbo.Users WHERE UserID = @USERID";

                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand(query, connection);
                    var guidId = Guid.Parse(id);
                    command.Parameters.AddWithValue("@USERID", guidId);
                    var user = new User();
                    var reader = await command.ExecuteReaderAsync();
                    
                    while (reader.Read())
                    { 
                        user = new User()
                        {
                            UserID = reader.GetString(reader.GetOrdinal("UserID")),
                            Username = reader.GetString(reader.GetOrdinal("Username")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName"))
                        };
                    }
                    return user;
                }
        }
        
        public async Task<User> GetUserByUsername(string username)
        {
            
            {
                
                var query = "SELECT UserID, Username, Password, FirstName, LastName FROM dbo.Users WHERE Username = @USERNAME";

                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@USERNAME", username);
                    var reader = await command.ExecuteReaderAsync();
                    var user = new User();
                    while (reader.Read())
                    { 
                        
                        user = new User()
                        {
                            UserID = reader.GetString(reader.GetOrdinal("UserID")),
                            Username = reader.GetString(reader.GetOrdinal("Username")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName"))
                        };
                        return user;
                    }

                    return user;


                }
            }
            
        }
    }
}

