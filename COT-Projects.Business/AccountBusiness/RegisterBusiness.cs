using AutoMapper;
using COT_Projects.Data.Entities;
using COT_Projects.Model.Models;
using COT_Projects.Model.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace COT_Projects.Business.AccountBusiness
{
    public class RegisterBusiness: IRegisterBusiness
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public RegisterBusiness(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        public async Task<RegistrationToken> Register(RegisterViewModel model)
        {
            var user = new ApplicationUser {FirstName=model.FirstName,LastName=model.LastName,UserName = model.Email,Email = model.Email,EmailConfirmed=true};
            var token = new RegistrationToken();
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user,"Client");
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

        public async Task<UserViewModel> UserProfile(string email)
        {
            return _mapper.Map<UserViewModel>(await _userManager.FindByEmailAsync(email));
        }

        public List<UserViewModel> Users()
        {
            var list = _userManager.Users;
            return list.Select(_mapper.Map<ApplicationUser, UserViewModel>).ToList();
        }
    }
}

