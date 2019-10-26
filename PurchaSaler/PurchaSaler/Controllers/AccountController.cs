using BLL;
using Models;
using PurchaSaler.Tools;
using System.Web.Mvc;

namespace PurchaSaler.Controllers
{
    public class AccountController : Controller
    {
        UsersManager usersManager = new UsersManager();

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
            //判断用户是否存在
            if (usersManager.UserIsExited(man.UserName))
            {
                return Content("用户已存在，请更换");
            }
            //判断两次密码是否一致
            //md5加密
            MD5Encryption md5 = new MD5Encryption();
            string hash = md5.GetMd5Hash(man.PassWord);
            return Content(hash);
        }

    }
}