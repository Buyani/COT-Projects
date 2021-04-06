using COT_Projects.Model.Models;
using COT_Projects.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace COT_Projects.Business.AccountBusiness
{
    public interface IRegisterBusiness
    {
        Task<RegistrationToken> Register(RegisterViewModel model);
        Task<bool> FindUser(string userName);
        Task <UserViewModel> UserProfile(string email);
    }
}
