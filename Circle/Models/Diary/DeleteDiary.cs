using System;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Circle.Models.Diary
{
    public interface IDeleteDiary
    {
        public Task Delete(string diaryId);
    }
    public class DeleteDiary : IDeleteDiary
    {
        private readonly string _connectionString;
        
        public DeleteDiary(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task Delete(string diaryId)
        {
            var query = "DELETE FROM dbo.Diary WHERE DiaryID = @DIARYID";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DIARYID", diaryId);

                await command.ExecuteNonQueryAsync();
            }
        }
    }
}