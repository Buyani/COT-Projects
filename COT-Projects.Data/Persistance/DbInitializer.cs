using COT_Projects.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COT_Projects.Data.Persistance
{
    public static class DbInitializer
    {
        public static async Task SeedUsersAsync(UserManager<IdentityUser> userManager,RoleManager<IdentityRole>roleManager)
        {
            if (userManager.FindByEmailAsync("admin@10trades.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "admin@10trades.com",
                    Email = "admin@10trades.com",
                    EmailConfirmed = true
                };
                IdentityUser user1 = new IdentityUser
                {
                    UserName = "buyani@10trades.com",
                    Email = "buyani@10trades.com",
                    EmailConfirmed = true
                };


                IdentityResult result = userManager.CreateAsync(user, "Admin$123").Result;
                IdentityResult result1 = userManager.CreateAsync(user1, "Buyani$123").Result;

                if (result.Succeeded)
                {
                    if(! await roleManager.RoleExistsAsync("Admin"))
                    {
                        await roleManager.CreateAsync(new IdentityRole { Name = "Admin", NormalizedName = "Admin" });
                    }

                    userManager.AddToRoleAsync(user, "Admin").Wait();

                }

                if(result1.Succeeded)
                {
                    if (!await roleManager.RoleExistsAsync("Client"))
                    {
                        await roleManager.CreateAsync(new IdentityRole { Name = "Client", NormalizedName = "Client" });
                    }
                    userManager.AddToRoleAsync(user1, "Client").Wait();

                }
            }
        }
    }
}
        

