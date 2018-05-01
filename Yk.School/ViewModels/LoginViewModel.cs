using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.Azure.KeyVault.Models;

namespace Yk.School.ViewModels
{
    public class LoginViewModel
    {
       
        [Required(ErrorMessage = "请输入登陆名!")]
        [DisplayName("登陆名")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "请输入密码!")]
        [DisplayName("密码")]  
        [StringLength(20,ErrorMessage = "密码长度为6-20位", MinimumLength = 6)]
        public string Password { get; set; }
    }
}