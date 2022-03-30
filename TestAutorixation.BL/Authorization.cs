using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutorixation.Core;
using TestAutorixation.Core.Model;

namespace TestAutorixation.BL
{
    public class Authorization : IAuthorization
    {
        public User GetUser(string login, string password)
        {
            //todo - временно 
            return new User() { Name="Ivan"} ;
        }

        public bool IsLogIn(string login, string password)
        {
            //todo - временно 
            return true;
        }
    }
}
