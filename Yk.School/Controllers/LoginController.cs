using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yk.School.Common;
using Yk.School.EntityFramework;
using Yk.School.Models;
using Yk.School.ViewModels;

namespace Yk.School.Controllers
{
    public class LoginController : BaseController
    {
        private readonly SchoolContext _context;

        public LoginController(SchoolContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == login.UserName);
                if (user == null)
                {
                    ViewData["Message"] = "用户不存在！";

                }
                else
                {
                    if (user.Password == Md5Helper.Encrypt(login.Password, 32))
                    {
                        UserInfo.RealName = user.RealName;
                        UserInfo.Id = user.Id;
                        SetCurrentId(user.Id);
                        SetCurrentRealName(user.RealName);
                        SetCurrentUserName(user.UserName);
                        return RedirectToAction(nameof(Index), "Home");
                    }
                    ViewData["Message"] = "密码错误！";
                }
            } 
            return View();
        }


        public IActionResult Logout()
        {
            UserInfo.RealName = "";
            UserInfo.Id = 0;
            SetCurrentId(0);
            SetCurrentRealName("");
            SetCurrentUserName(""); 
            return View("Login");
        }

    }
}