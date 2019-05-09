using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace JWTExample.Core.Entities.Data
{
    public class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            ApplicationDbContext context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            UserManager<ApplicationUser> userManeger = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            context.Database.EnsureCreated();

            if (!context.Users.Any())
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Email = "nuriumut.cakar@hotmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "Umut"
                };

                var x = userManeger.CreateAsync(user, "Password@123");
            }
        }
    }
}
