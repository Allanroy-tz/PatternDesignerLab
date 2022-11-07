using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagementSys
{
    public interface Tz20200440718_IMessage
    {
        /// <param name="medium">发送媒介</param>
        /// <param name="message">要发送的消息</param>
        void PostMessage(string medium, string message);
    }
}