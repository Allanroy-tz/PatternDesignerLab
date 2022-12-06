using System;
using System.Collections.Generic;
using System.Text;

namespace 网上书店
{
    public abstract class Subject
    {
        protected List<Observer> userList = new List<Observer>();
        public abstract void Attach(Observer obs);
        public abstract void Detach(Observer obs);
        public abstract void Notify();
    }
}