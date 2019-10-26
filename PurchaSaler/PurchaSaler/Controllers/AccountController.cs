using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace PurchaSaler.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Users man)
        {
            UsersManager usersManager = new UsersManager();
            Users info = usersManager.GetUserInfo(man.UserName);
            if (usersManager.UserIsExited(man.UserName))
            {
                return Content("用户已存在");
            }
            return Content("用户不存在");
        }
    }
}