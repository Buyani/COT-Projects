using COT_Projects.Data.Entities;
using COT_Projects.Model.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace COT_Projects.Business.AccountBusiness
{
    public class LogInBusiness: ILogInBusiness
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public LogInBusiness(UserManager<ApplicationUser> userManager,
                              SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<bool> LogUserIn(LoginModel model,bool RememberMe)
        {
            bool token = false;
            var user = await _userManager.FindByNameAsync(model.Email);
            var paswsord = await _userManager.CheckPasswordAsync(user, model.Password);
            if(paswsord)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    token = true;
                }
            }
            return token;
        }
        public async Task LogOut()
        {
            await _signInManager.SignOutAsync();
        }


    }
}
