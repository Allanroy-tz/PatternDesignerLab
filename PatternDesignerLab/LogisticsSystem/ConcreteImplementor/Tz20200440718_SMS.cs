using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsSystem
{
    public class Tz20200440718_SMS : Tz20200440718_AbstractMedium
    {
        public override string Post(string message)
        {
            return this.message.PostMessage("手机短信", message);
        }
    }
}