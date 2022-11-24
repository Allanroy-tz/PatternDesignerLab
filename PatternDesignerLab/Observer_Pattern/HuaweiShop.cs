using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class HuaweiShop : Subject
    {
        public override void Attach(Observer obs)
        {
            obsList.Add(obs);
        }

        public override void Detach(Observer obs)
        {
            obsList.Remove(obs);
        }

        public override void Notify()
        {
            foreach (Observer obs in obsList)
            {
                obs.Update();
            }
        }
    }
}