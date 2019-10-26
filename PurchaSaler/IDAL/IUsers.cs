using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
    public interface IUsers
    {
        //用户是否存在
        bool UserIsExited(string UserName);
        //添加用户
        void AddUser(Users man);
        //删除用户
        void DelUser(Users man);
        //修改用户信息
        void UpdatePassWord(Users info);
        //查找用户
        Users GetUserInfo(string UserName);
        
    }
}
