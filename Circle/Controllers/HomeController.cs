using System.Security.Claims;
using System.Threading.Tasks;
using Circle.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Circle.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly IGetUser _getUser;

        public HomeController(IGetUser getUser)
        {
            _getUser = getUser;
        }
        // GET
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _getUser.GetUserById(userId);
            return View(user);
        }
    }
}