using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsSystem
{
    public abstract class Tz20200440718_AbstractMedium
    {
        protected Tz20200440718_IMessage message;
        public void SetMessage(Tz20200440718_IMessage message)
        {
            this.message = message;
        }
        public abstract string Post(string message);
    }
}