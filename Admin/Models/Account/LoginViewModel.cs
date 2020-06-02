using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Account
{
    public class LoginViewModel
    {[Required(ErrorMessage ="Email vacibdir!")]
    [EmailAddress(ErrorMessage ="Duzgun Email daxil edin")]
    [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Sifre Vacibdir!")]
        [MinLength(6,ErrorMessage ="Min.6 xarakter olamlidi!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

      
        public bool RememberMe { get; set; }
    }
}
