using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    public abstract class Unit
    {
        private string name;
        public string Name { get { return name; } }
        public Unit(string name)
        {
            this.name = name;
        }
        public abstract void Receive(string msg);
    }
}