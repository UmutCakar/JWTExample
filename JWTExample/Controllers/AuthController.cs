using System.Threading.Tasks;
using JWTExample.Core.Entities.Data;
using JWTExample.Core.Entities.Models;
using JWTExample.Core.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;

namespace JWTExample.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IConfiguration configuration;

        public AuthController(
            UserManager<ApplicationUser> userManager,
            IConfiguration configuration
            )
        {
            this.userManager = userManager;
            this.configuration = configuration;

        }

        [Route("login"), HttpPost]
        public async Task<IActionResult> Login([FromBody] Login model)
        {
            var user = await userManager.FindByNameAsync(model.Username);

            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                string secretKey = configuration.GetValue<string>("JWTSecretKey");
                string token = JwtTokenHelper.CreateToken(user.UserName, secretKey);

                return Ok(new
                {
                    token = token,
                });
            }

            return Unauthorized();
        }
    }
}