using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels
{
    public class LoginViewModel
    {

        public string Email { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public bool LoginFast { get; set; }

        public string ReturnUrl { get; set; }
    }
}
