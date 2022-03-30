using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutorixation.Core;

namespace TestAutorixation.MSSQLDB
{
    public class UserController : IUserContoroller
    {
        


        public void AddUser(Core.Model.User user)
        {
            using MsContext msContext = new MsContext();
            try
            {
                if(IsLogIn(user.Login )== true)
                {
                    throw new Exception($"Ошибка при добавлении в  ДБ логин {user.Login} уже существует");
                }

               msContext.Add(new User { Login = user.Login , Password = user.Password,
               UserName = user.Name
               });
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при добавлении в  ДБ логин {user.Login}");
            }
        }

        public Core.Model.User GetUser(string login)
        {
           using MsContext msContext = new MsContext();
            try
            {
               var usDb = msContext.Users.Single(u => u.Login == login);
               return new Core.Model.User { Login = usDb.Login 
                    , Name = usDb.UserName , Password = usDb.Password 
                    };
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при выборки  в  ДБ логин {login}");
            }
        }

        public List<Core.Model.User> GetUsers()
        {
            using MsContext msContext = new MsContext();
            try
            {
                List<Core.Model.User> users = new List<Core.Model.User>();

                foreach (var item in msContext.Users.ToList())
                {
                    users.Add(GetUser(item.Login));
                }
                return users;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при выборки  в  ДБ");
            }
        }

        public bool IsLogIn(string login)
        {
            using MsContext msContext = new MsContext();
            try
            {
                return msContext.Users.Any(x=>x.Login == login);    
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при выборки  в  ДБ - логин {login}");
            }
        }
    }
}
