namespace LogisticsManagementSys
{
    public class Tz20200440718_NormalMessage : Tz20200440718_IMessage
    {
        public void PostMessage(string medium, string message)
        {
            System.Console.WriteLine(string.Format("{0}:普通消息：“{1}”", medium, message));
        }
    }
}