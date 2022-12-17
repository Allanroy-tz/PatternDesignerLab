using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
    public abstract class Tz0718Subject
    {
        protected List<Tz0718User> userList = new List<Tz0718User>();
        public void AddUser(Tz0718User user) { userList.Add(user); }
        public void RemoveUser(Tz0718User user) { userList.Remove(user); }
        public abstract void Notify(string msg);

    }
}