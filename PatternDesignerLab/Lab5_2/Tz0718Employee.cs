using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class Tz0718Employee : Tz0718User
    {
        public Tz0718Employee(string name) { this.name = name; }
        public override void Action(string msg)
        {
            System.Console.WriteLine("{0}收到消息：{1}", name, msg);
        }

        public override void Add(Tz0718User user)
        {
        }

        public override Tz0718User GetChild(int i)
        {
            return null;
        }

        public override void Remove(Tz0718User user)
        {
        }
    }
}
