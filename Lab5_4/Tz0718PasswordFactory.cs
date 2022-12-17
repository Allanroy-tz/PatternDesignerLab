using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_4
{
    class Tz0718PasswordFactory : Tz0718IFactory
    {
        public Tz0718IAuthentication GetAuthentication()
        {
            return new Tz0718Password();
        }
    }
}
