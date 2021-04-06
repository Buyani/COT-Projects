﻿using COT_Projects.Data.Entities;
using COT_Projects.Model.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace COT_Projects.Business.AccountBusiness
{
    public class RegisterBusiness: IRegisterBusiness
    {
        private readonly UserManager<IdentityUser> _userManager;

        public RegisterBusiness(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<RegistrationToken> Register(RegisterViewModel model)
        {
            var user = new ApplicationUser {FirstName=model.FirstName,LastName=model.LastName,UserName = model.Email,Email = model.Email,EmailConfirmed=true};
            var token = new RegistrationToken();
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                //await _signInManager.SignInAsync(user, isPersistent: false);
                token.Results = true;
                token.EmailConfimationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                token.User = user;
            }
            return token;
        }
        public async Task<bool> FindUser(string userName)
        {
            var user =await _userManager.FindByNameAsync(userName);

            if(user!=null)
            {
                return true;
            }
            return false;
        }
    }
}

