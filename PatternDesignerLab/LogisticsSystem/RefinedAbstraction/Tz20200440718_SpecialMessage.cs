
using System.Timers;

namespace LogisticsManagementSys
{
    public class Tz20200440718_SpecialMessage : Tz20200440718_IMessage
    {
        bool isReplied = false;
        int num = 0;
        public void PostMessage(string medium, string message)
        {
            System.Console.WriteLine("{0}:特殊消息：“{1}”", medium, message);
            System.Console.WriteLine("请回复：确认");
            Timer timer = new Timer(4000);
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Start();
            string input = System.Console.ReadLine();

            if (input == "确认" || isReplied)
            {
                timer.Close();
                isReplied = true;
                System.Console.WriteLine("已收到您的确认信息");
                return;
            }
            void Timer_Elapsed(object sender, ElapsedEventArgs e)
            {
                System.Console.WriteLine("{0}:特殊消息：“{1}”", medium, message);
                System.Console.WriteLine("请回复：确认");
                num++;
                if (num >= 2)
                {
                    timer.Close();
                    System.Console.WriteLine("未收到您的确认信息");
                    input = "";
                    return;
                }
            }

        }


    }
}