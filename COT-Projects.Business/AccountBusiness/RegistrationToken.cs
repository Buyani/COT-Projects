using COT_Projects.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace COT_Projects.Business.AccountBusiness
{
    public class RegistrationToken
    {
        public bool Results { get; set; }
        public string EmailConfimationToken { get; set; }
        public ApplicationUser User { get; set; }
    }
}
