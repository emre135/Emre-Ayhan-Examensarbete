using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;

namespace Circle.Models
{
    public interface IUserAuthentication
    {
        public Task Login(string id, string username);
    }
    public class UserAuthentication : IUserAuthentication
    {
        private IHttpContextAccessor _HttpContextAccessor { get; }

        public UserAuthentication(IHttpContextAccessor httpContextAccessor)
        {
            _HttpContextAccessor = httpContextAccessor;
        }
        
        public async Task Login(string id, string username)
        {
            var userClaims = new List<Claim>()
            {
                
                new Claim(ClaimTypes.NameIdentifier, id),
                new Claim(ClaimTypes.Name, username)
            };
            var userIdentity = new ClaimsIdentity(userClaims, "CookieAuth");
            var userPrincipal = new ClaimsPrincipal(userIdentity);
            await _HttpContextAccessor.HttpContext.SignInAsync("CookieAuth", userPrincipal);
        }

    }
}