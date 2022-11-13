using System.Windows.Forms;

namespace LogisticsSystem
{
    public class Tz20200440718_SpecialMessage : Tz20200440718_IMessage
    {
        public int num = 5;
        public int interval=1000;
        //int Tz20200440718_IMessage.Num { get => num; set =>num=value;}
        Timer timer=new Timer();
        public string PostMessage(string medium, string message)
        {
            timer.Interval = interval;
            timer.Start();
            return string.Format("{0}:{1}:特殊消息：“{2}”\r\n请回复：确认", System.DateTime.Now.ToString(), medium, message);
        }
        public void StopTimer()
        {
            timer.Stop();
        }
    }
}