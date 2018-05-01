using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Yk.School.Models
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        public const string DefaultPassword = "123qwe";
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 登陆名称
        /// </summary>
        [Required]
        [MaxLength(20)]
        [DisplayName("登陆名")]
        public string UserName { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        [Required]
        [MaxLength(20)]
        [DisplayName("真实名称")]
        public string RealName { get; set; } 
        /// <summary>
        /// 邮箱
        /// </summary>
        [EmailAddress]
        [DisplayName("邮箱")]
        public string Email { get; set; }
        /// <summary>
        /// 密码
        /// </summary>

        [StringLength(20, ErrorMessage = "密码长度为6-20位", MinimumLength = 6)]

        public string Password { get; set; }
    }
}