using System;

namespace LogisticsManagementSys
{
    class Program
    {
        static void Main(string[] args)
        {
            Tz20200440718_SpecialMessage message = new Tz20200440718_SpecialMessage();
            message.PostMessage("WeChat", "货物到啦");
        }
    }
}
