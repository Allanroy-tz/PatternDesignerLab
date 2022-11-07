namespace LogisticsSystem
{
    public class Tz20200440718_SpecialMessage : Tz20200440718_IMessage
    {
        public string PostMessage(string medium, string message)
        {
            return string.Format("{0}:{1}:特殊消息：“{2}”\r\n请回复：确认", System.DateTime.Now.ToString(), medium, message);
        }
    }
}