using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Circle.Models.Diary
{
    public interface IGetDiary
    {
        public Task<List<Diary>> GetAll(string author);
    }
    
    public class GetDiary : IGetDiary
    {
        
        private readonly string _connectionString;
        
        public GetDiary(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public async Task<List<Diary>> GetAll(string author)
        {
            {
                
                var query = "SELECT DiaryID, DatePosted, Title, Text, Author FROM dbo.Diary WHERE Author = @AUTHOR";

                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AUTHOR", author);
                    var reader = await command.ExecuteReaderAsync();
                    var diaryList = new List<Diary>();
                    while (reader.Read())
                    { 
                        
                        var diary = new Diary()
                        {
                            DiaryID = reader.GetString(reader.GetOrdinal("DiaryID")),
                            Date = reader.GetDateTime(reader.GetOrdinal("DatePosted")),
                            Title = reader.GetString(reader.GetOrdinal("Title")),
                            Text = reader.GetString(reader.GetOrdinal("Text")),
                            Author = reader.GetString(reader.GetOrdinal("Author"))
                        };
                        diaryList.Add(diary);
                    }

                    return diaryList;


                }
            }
        }
    }
}