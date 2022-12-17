using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class Tz0718Department : Tz0718User
    {
        List<Tz0718User> userList = new List<Tz0718User>();
        public Tz0718Department(string name) { this.name = name; }

        public override void Action(string msg)
        {
            System.Console.WriteLine("{0}收到消息", name);
            foreach (Tz0718User user in userList)
            {
                user.Action(msg);
            }
        }
        public void SendMsg(string name,string msg)
        {
            foreach (Tz0718User user in userList)
            {
                if (user.GetName() == name)
                {
                    user.Action(msg);
                    return;
                }
                    
            }
        }
        public override void Add(Tz0718User user)
        {
            userList.Add(user);
        }

        public override Tz0718User GetChild(int i)
        {
            return userList[i];
        }

        public override void Remove(Tz0718User user)
        {
            userList.Remove(user);
        }
    }
}
