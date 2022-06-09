using System.Security.Claims;
using System.Threading.Tasks;
using Circle.Models;
using Circle.Models.Diary;
using Microsoft.AspNetCore.Mvc;

namespace Circle.Controllers
{
    [Route("post")]
    public class PostController : Controller
    {
        private readonly IGetUser _getUser;
        private readonly IPostDiary _postDiary;

        public PostController(IGetUser getUser, IPostDiary postDiary)
        {
            _getUser = getUser;
            _postDiary = postDiary;
        }
        
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> NewPost(string title, string text)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _getUser.GetUserById(userId);
            var author = user.Username;
            await _postDiary.Post(title, text, author);
            return Ok( new
            {
                message = "Submitted a new post to diary!"
            });
        }
    }
}