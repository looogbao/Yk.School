using System.Linq;
using Yk.School.Common;
using Yk.School.Models;

namespace Yk.School.EntityFramework.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {

            // 检查是否有学生信息
            if (context.Users.Any())
            {
                return; //返回，不执行。
            }

            #region 添加默认用户
            context.Users.Add(new User { UserName = "admin", RealName = "系统管理员", Password = Md5Helper.Encrypt(User.DefaultPassword,32) });
            context.SaveChanges(); 
            #endregion

        }
    }
}