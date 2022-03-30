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
            return new Authorization(GetUserContoroller());
        }

        internal static IUserContoroller GetUserContoroller()
        {
            return new UserController();
        }
    }
}