using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public abstract class AbstractChatroom
    {
        protected Dictionary<string, Member> memberList=new Dictionary<string, Member>();
        public abstract void Register(Member member);

        public abstract void SendMsg(string from, string to, string msg);
    }
}