using COT_Projects.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace COT_Projects.Business.AccountBusiness
{
    public interface ILogInBusiness
    {
        Task<bool> LogUserIn(LoginModel model,bool RememberMe);
        Task LogOut();
    }
}
