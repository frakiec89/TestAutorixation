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
        public Core.Model.User GetUser(string login, string password)
        {
            MsContext  msContext = new MsContext();
            var userDb =  msContext.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
            return MapUSer(userDb);
        }

        private Core.Model.User MapUSer(MSSQLDB.User userDb)
        {
           return new Core.Model.User { Password =userDb.Password , Login=userDb.Login , Name = userDb.UserName};
        }

        public bool IsLogIn(string login, string password)
        {
            MsContext msContext = new MsContext();
           return  msContext.Users.Any(x => x.Login == login && x.Password == password);
        }
    }

   
}
