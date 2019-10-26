using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using DALFactory;
using Models;

namespace BLL
{
    public class UsersManager
    {
        private IUsers iusers = DataAccess.CreateUser();

        //用户是否存在
        public bool UserIsExited(string UserName)
        {
            return iusers.UserIsExited(UserName);
        }
        //添加用户
        public void AddUser(Users man)
        {
            iusers.AddUser(man);
        }
        //删除用户
        public void DelUser(Users man)
        {
            iusers.DelUser(man);
        }
        //修改用户信息
        public void UpdatePassWord(Users info)
        {
            iusers.UpdatePassWord(info);
        }
        //查找用户
        public Users GetUserInfo(string UserName)
        {
            return iusers.GetUserInfo(UserName);
        }
    }
}
