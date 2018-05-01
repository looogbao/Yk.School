using System.Runtime.InteropServices.ComTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Yk.School.Controllers
{
    public class BaseController:Controller
    {
        private const string SessionPrefix = "YkSchoolSession";
        public int CurrentUserId
        {
            get
            {
                var id = 0;
                if (HttpContext.Session.GetString(SessionPrefix + "UserId") != null)
                {
                    id = int.Parse(HttpContext.Session.GetString(SessionPrefix + "UserId"));
                }
                return id; 
            }
        }

        public string CurrentUserName
        {
            get
            {
                var userName = "";
                if (HttpContext.Session.GetString(SessionPrefix + "UserName") != null)
                {
                    userName = HttpContext.Session.GetString(SessionPrefix + "UserName");
                }
                return userName;
            }
        }

        public string CurrentRealName
        {
            get
            {
                var realName = "";
                if (HttpContext.Session.GetString(SessionPrefix + "RealName") != null)
                {
                    realName = HttpContext.Session.GetString(SessionPrefix + "RealName");
                }
                return realName;
            } 
        } 

        public bool IsLogin()
        {
            return CurrentUserId != 0;
        }

        public void SetCurrentId(int id)
        {
            HttpContext.Session.SetString(SessionPrefix + "UserId",id.ToString());
        }

        public void SetCurrentUserName(string userName)
        {
            HttpContext.Session.SetString(SessionPrefix + "UserName", userName);
        }
        public void SetCurrentRealName(string realName)
        {
            HttpContext.Session.SetString(SessionPrefix + "RealName", realName);
        }
    }
}