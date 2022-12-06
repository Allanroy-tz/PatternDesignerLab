using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Tz20200440718_HuaweiShop : Tz20200440718_Subject
    {
        public override void Attach(Tz20200440718_Observer obs)
        {
            obsList.Add(obs);
        }

        public override void Detach(Tz20200440718_Observer obs)
        {
            obsList.Remove(obs);
        }

        public override void Notify()
        {
            foreach (Tz20200440718_Observer obs in obsList)
            {
                obs.Update();
            }
        }
    }
}