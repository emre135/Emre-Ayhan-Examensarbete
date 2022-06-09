using Circle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Internal;

namespace Circle.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        private readonly IUserAuthentication _userAuthentication;
        private readonly IGetUser _getUser;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginController(IUserAuthentication userAuthentication, IGetUser getUser, IHttpContextAccessor httpContextAccessor)
        {
            _userAuthentication = userAuthentication;
            _getUser = getUser;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [Route("init")]
        public async Task<IActionResult> Login(string username, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    throw new Exception("Please fill in a username!");
                }

                if (string.IsNullOrEmpty(password))
                {
                    throw new Exception("Please fill in a password!");
                }
                   
                   
               var verifiedUser = await _getUser.VerifyUser(username, password);
               
               if (string.IsNullOrEmpty(verifiedUser.UserID))
               {
                   throw new Exception("User does not exist!");
               }


                
                await _userAuthentication.Login(verifiedUser.UserID, verifiedUser.Username);
                
                return Ok(new
                    {
                        success = true
                    });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return BadRequest(new
                {
                    message = ex
                });
            }
           
        }
    }
}
