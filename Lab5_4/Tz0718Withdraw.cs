using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_4
{
    public class Tz0718Withdraw : Tz0718BankTerminal
    {
        public override void BusinessHandle()
        {
            Console.WriteLine("执行转账操作");
        }

        public override void Verfication()
        {
        }
    }
}
