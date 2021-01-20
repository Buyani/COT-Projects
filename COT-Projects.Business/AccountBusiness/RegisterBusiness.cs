using COT_Projects.Data.Entities;
using COT_Projects.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COT_Projects.Business.AccountBusiness
{
    public class RegisterBusiness
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;


        public RegisterBusiness(UserManager<ApplicationUser> userMananger, SignInManager<ApplicationUser> signInManager, ILogger logger)
        {
            _userManager = userMananger;
            _signInManager = signInManager;
            _logger = logger;
        }



    }
}
