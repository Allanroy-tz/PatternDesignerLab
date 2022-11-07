namespace LogisticsSystem
{
    public class Tz20200440718_NormalMessage : Tz20200440718_IMessage
    {
        public string PostMessage(string medium, string message)
        {
            return string.Format("{0}：{1}:普通消息：“{2}”", System.DateTime.Now.ToString(), medium, message);
        }
    }
}