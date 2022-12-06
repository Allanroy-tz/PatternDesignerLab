using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public abstract class Tz20200440718_Subject
    {
        protected List<Tz20200440718_Observer> obsList = new List<Tz20200440718_Observer>();
        public abstract void Attach(Tz20200440718_Observer obs);
        public abstract void Detach(Tz20200440718_Observer obs);
        public abstract void Notify();
    }
}