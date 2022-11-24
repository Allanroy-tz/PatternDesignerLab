using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public class ConcreteMember : Member
    {
        public ConcreteMember(string name) : base(name)
        {
        }

        public override void SendMsg(string to, string msg)
        {
            System.Console.WriteLine("{0}给{1}发送了消息：{2}", name, to, msg);
            chatroom.SendMsg(name, to, msg);
        }
    }
}