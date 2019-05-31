using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chrissiteMVC.Data
{
    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "youremail@email.com",
                    Email = "youremail@email.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "AdminPassword123$").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}
