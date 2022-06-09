using System;
using Circle.Models;
using Microsoft.AspNetCore.Mvc;

namespace Circle.Controllers
{
    [Route("register")]
    public class RegisterController : Controller
    {
        private readonly IRegisterUser _registerUser;
        public RegisterController(IRegisterUser registerUser)
        {
            _registerUser = registerUser;
        }
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("init")]
        public IActionResult Register(User user, string confirmPassword)
        {
            try
            {
                if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.FirstName) 
                                                        || string.IsNullOrEmpty(user.LastName) 
                                                        || string.IsNullOrEmpty(user.Password))
                {
                    throw new Exception("Please fill in all fields!");
                }

                if (user.Password != confirmPassword)
                {
                    throw new Exception("Passwords did not match, try again!");
                }
                
                _registerUser.Register(user.Username, user.Password, user.FirstName, user.LastName);
                
                
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    message = ex
                });
            }
            return Ok( new
            {
                message = "User successfully registered!"
            });
        }
    }
}