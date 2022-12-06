using System;
using System.Collections.Generic;
using System.Text;

namespace 网上书店
{
    public class User : Observer
    {
        public AbstractVIP VIP
        {
            get;
            private set;
        }
        public string usrName
        {
            get;
            private set;
        }
        public User(string name) { this.usrName = name; }

        public void Update(string msg)
        {
            System.Console.WriteLine("{0}收到了消息：{1}", usrName, msg);
        }
    }
}