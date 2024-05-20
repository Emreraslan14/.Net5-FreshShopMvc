using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshShop.Model.ViewModels
{
    public class ManagerLogInVm
    {
        [Required(ErrorMessage ="Kullanıcı Adı Zorunludur.")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Şifre Zorunludur.")]
        [MinLength(3,ErrorMessage ="Şifre en az 3 karakter içermeli.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
