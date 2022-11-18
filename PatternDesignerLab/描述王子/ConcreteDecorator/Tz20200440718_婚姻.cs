using System;
using System.Collections.Generic;
using System.Text;

namespace 描述王子
{
    public class Tz20200440718_婚姻 : Tz20200440718_各路人马
    {
        public Tz20200440718_婚姻(Tz20200440718_特征 龙傲天) : base(龙傲天) { }
        public string 调查婚姻情况()
        {
            return "婚姻情况：未婚\n";
        }
        public override string 描述()
        {
            string tz = base.描述();
            tz += 调查婚姻情况();
            return tz;
        }
    }
}