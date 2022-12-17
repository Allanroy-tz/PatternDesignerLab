using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_4
{
    public class Tz0718Transfer : Tz0718BankTerminal
    {
        public override void BusinessHandle()
        {
            Console.WriteLine("执行转账");
        }

        public override void Verfication()
        {
            Console.WriteLine("向用户发送验证码");
        }
    }
}
