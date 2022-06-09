using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Circle.Controllers
{
    public class LogoutController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LogoutController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        // GET
        public async Task<IActionResult> SignOut()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _httpContextAccessor.HttpContext.SignOutAsync(userId);
            return RedirectToAction("Index", "Login");
        }
    }
}