using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsSystem
{
    
    
    public interface Tz20200440718_IMessage
    {
        /// <summary>
        /// 生命周期
        /// </summary>
        /// <param name="medium">发送媒介</param>
        /// <param name="message">要发送的消息</param>
        string PostMessage(string medium, string message);
    }
}