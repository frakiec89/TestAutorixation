using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutorixation.Core;
using TestAutorixation.Core.Model;
using TestAutorixation.MSSQLDB;

namespace TestAutorixation.BL
{
    public class Authorization : IAuthorization
    {
        private IUserContoroller _userContoroller;

        public Authorization (IUserContoroller userContoroller)//проброс зависимости
        {
            _userContoroller = userContoroller;
        }

        public Core.Model.User GetUser(string login, string password)
        {
            return _userContoroller.GetUser(login);
        }

        public bool IsLogIn(string login, string password)
        {
            if (_userContoroller.IsLogIn(login) == true)
            {
                var us = _userContoroller.GetUser(login);
                if(us.Password == password)
                    return true;
                else
                    return false;
            }

            return false;
        }
    }

   
}
