using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagementSys
{
    public class Tz20200440718_SMS : Tz20200440718_AbstractMedium
    {
        public override void Post(string message)
        {
            this.message.PostMessage("手机短信", message);
        }
    }
}