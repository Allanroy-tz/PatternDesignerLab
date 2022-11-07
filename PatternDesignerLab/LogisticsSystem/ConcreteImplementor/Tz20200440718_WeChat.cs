using System;

namespace LogisticsManagementSys
{
    public class Tz20200440718_WeChat : Tz20200440718_AbstractMedium
    {
        public override void Post(string message)
        {
            this.message.PostMessage("微信", message);
        }
    }
}