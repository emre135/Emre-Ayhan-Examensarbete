using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Circle.Models.Diary
{

    public interface IPostDiary
    {
        public Task Post(string title, string text, string author);
    }
    public class PostDiary : IPostDiary
    {
        private readonly string _connectionString;
        
        public PostDiary(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public async Task Post(string title, string text, string author)
        {
            {
                var query = "INSERT INTO dbo.Diary(DiaryID, DatePosted, Title, Text, Author) " +
                            "VALUES(@DIARYID, @DATEPOSTED, @TITLE, @TEXT, @AUTHOR)";

                using (var connection = new SqlConnection(_connectionString))
                {
                    var id = Guid.NewGuid();
                    var datePosted = DateTime.Now;
                    
                    
                    connection.Open();
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DIARYID", id);
                    command.Parameters.AddWithValue("@DATEPOSTED", datePosted);
                    command.Parameters.AddWithValue("@TITLE", title);
                    command.Parameters.AddWithValue("@TEXT", text);
                    command.Parameters.AddWithValue("@AUTHOR", author);
                    
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}