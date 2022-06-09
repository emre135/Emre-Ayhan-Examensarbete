using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Circle.Models;
using Circle.Models.Diary;
using Microsoft.AspNetCore.Mvc;

namespace Circle.Controllers
{
    [Route("diary")]
    public class DiaryController : Controller
    {
        
        private readonly IGetUser _getUser;
        private readonly IPostDiary _postDiary;
        private readonly IGetDiary _getDiary;
        private readonly IDeleteDiary _deleteDiary;

        public DiaryController(IGetUser getUser, IPostDiary postDiary, IGetDiary getDiary, IDeleteDiary deleteDiary)
        {
            _getUser = getUser;
            _postDiary = postDiary;
            _getDiary = getDiary;
            _deleteDiary = deleteDiary;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var username = User.FindFirstValue(ClaimTypes.Name);
            var diaryList= await _getDiary.GetAll(username);
            
            
            return View(diaryList);
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> Delete(string diaryId)
        {
            try
            {
                if (string.IsNullOrEmpty(diaryId))
                {
                    throw new Exception("Something went wrong!");
                }
                await _deleteDiary.Delete(diaryId);
                return Ok(new
                {
                    message = "Deleted diary!"
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Ok(new
                {
                    message = ex
                });
            }
        }
    }
}