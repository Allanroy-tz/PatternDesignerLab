using System;

namespace LogisticsSystem
{
    public class Tz20200440718_WeChat : Tz20200440718_AbstractMedium
    {
        public override string Post(string message)
        {
            return this.message.PostMessage("微信", message);
        }
    }
}