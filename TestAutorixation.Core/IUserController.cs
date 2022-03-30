using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutorixation.Core
{
    public interface IUserContoroller
    {
        void AddUser(Core.Model.User user);
        Core.Model.User GetUser(string login);
        List<Core.Model.User> GetUsers();
        bool IsLogIn(string login);
    }
}
