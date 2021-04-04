using System;
using System.Collections.Generic;
using System.Text;

namespace COT_Projects.Model.Models
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool RememberMe { get; set; }
    }
}
