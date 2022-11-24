

namespace Mediator_Pattern
{
    public abstract class Member
    {
        protected AbstractChatroom chatroom;
        public string name;
        public Member(string name) { this.name = name; }
        public AbstractChatroom GetChatroom()
        {
            return chatroom;
        }

        public void SetChatroom(AbstractChatroom chatroom)
        {
            this.chatroom = chatroom;
            chatroom.Register(this);
        }

        public abstract void SendMsg(string to, string msg);

        public void Receive(string from,string msg)
        {
            System.Console.WriteLine("{0}收到{1}发送的消息：{2}", name, from, msg);
        }
    }
}