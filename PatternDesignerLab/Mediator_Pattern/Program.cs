using System;

namespace Mediator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AbstractChatroom chatroom = new ChatGroup();
            Member member01 = new ConcreteMember("卖家");
            Member member02 = new ConcreteMember("买家");
            member01.SetChatroom(chatroom);
            member02.SetChatroom(chatroom);

            member01.SendMsg("买家", "欢迎光临");
            member01.SendMsg("卖家", "我要卖10件");
        }
    }
}
