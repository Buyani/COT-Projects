using COT_Projects.Model.Models;
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
    }
}
