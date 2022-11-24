using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public class ChatGroup : AbstractChatroom
    {
        public override void Register(Member member)
        {
            memberList.Add(member.name, member);
        }

        public override void SendMsg(string from, string to, string msg)
        {
            memberList[to].Receive(from, msg);
        }
    }
}