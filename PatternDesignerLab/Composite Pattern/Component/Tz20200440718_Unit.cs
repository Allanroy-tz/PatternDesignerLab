using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    public abstract class Tz20200440718_Unit
    {
        private string name;
        public string Name { get { return name; } }
        public Tz20200440718_Unit(string name)
        {
            this.name = name;
        }
        public abstract void Receive(string msg);
    }
}