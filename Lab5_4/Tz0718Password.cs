using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_4
{
    public class Tz0718Password : Tz0718IAuthentication
    {
        public void Authorize()
        {
            System.Console.WriteLine("使用密码验证");
        }
    }
}
