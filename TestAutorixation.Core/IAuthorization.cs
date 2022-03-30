using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutorixation.Core.Model;

namespace TestAutorixation.Core
{
    public interface IAuthorization
    {
        bool IsLogIn(string login, string password);
        User GetUser(string login, string password);

    }
}
