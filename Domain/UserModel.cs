using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string email, string pass)
        {
            return userDao.Login(email, pass);
        }

        public string RecoverPassword(string userRequesting)
        {
            return userDao.RecoverPassword(userRequesting);
        }
    }
}
