using System;
using TestAutorixation.BL;
using TestAutorixation.Core;

namespace TestAutorixation.MyWPF
{
    internal class MyBild
    {
        internal static IAuthorization GetAuthorization()
        {
            return new Authorization();
        }
    }
}