using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public abstract class Subject
    {
        protected List<Observer> obsList = new List<Observer>();
        public abstract void Attach(Observer obs);
        public abstract void Detach(Observer obs);
        public abstract void Notify();
    }
}