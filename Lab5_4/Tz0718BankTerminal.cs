using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_4
{
    public abstract class Tz0718BankTerminal
    {
        private Tz0718IFactory factory;
        public void Authentication() { factory.GetAuthentication().Authorize(); }
        public abstract void BusinessHandle();
        public void CardInsert() { Console.WriteLine("插入银行卡"); }
        public void CheckOut() { Console.WriteLine("拔出银行卡"); }
        public Tz0718IFactory GetFactory() { return factory; }
        public void SetFactory(Tz0718IFactory factory) { this.factory = factory; }
        public abstract void Verfication();
        public void Process()
        {
            CardInsert();
            Authentication();
            BusinessHandle();
            Verfication();
            CheckOut();
        }


    }
}
