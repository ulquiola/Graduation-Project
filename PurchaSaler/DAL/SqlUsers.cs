using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;

namespace DAL
{
    public class SqlUsers : IUsers
    {
        //创建数据库上下文对象
        PurchaSaler db = new PurchaSaler();

        //用户是否存在
        public bool UserIsExited(string UserName)
        {
            bool res = db.Users.Any(u => u.UserName == UserName);
            return res;
        }
        //添加用户
        public void AddUser(Users man)
        {
            db.Users.Add(man);
            db.SaveChanges();
        }
        //删除用户
        public void DelUser(Users man)
        {
            db.Users.Remove(man);
            db.SaveChanges();

        }
        //修改用户信息
        public void UpdatePassWord(Users info)
        {
            var someone = db.Users.Where(u => u.UserName == info.UserName).FirstOrDefault();
            
            someone.PassWord = info.PassWord;

            db.SaveChanges();
        }
        //查找用户
        public Users GetUserInfo(string UserName) 
        {
            var info = db.Users.Where(u => u.UserName == UserName).FirstOrDefault();
            return info;
        }
    }
}
