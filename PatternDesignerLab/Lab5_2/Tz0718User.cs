using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    public abstract class Tz0718User
    {
        protected string name;
        public string GetName() { return name; }
        public abstract void Add(Tz0718User user);
        public abstract void Remove(Tz0718User user);
        public abstract Tz0718User GetChild(int i);
        public abstract void Action(string msg);
    }
}
