using System;
using TestAutorixation.BL;
using TestAutorixation.Core;
using TestAutorixation.MSSQLDB;

namespace TestAutorixation.MyWPF
{
    internal class MyBild
    {
        internal static IAuthorization GetAuthorization()
        {
                return new Authorization(GetUserContoroller() ); // проброс  объекта  базы данных
        }

        internal static IUserContoroller GetUserContoroller()
        {
            return new UserController(); //  база данных 
        }
    }
}