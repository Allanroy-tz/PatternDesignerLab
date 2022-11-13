using System;
using System.Collections.Generic;
using System.Text;

namespace 描述王子
{
    public class 婚姻 : 各路人马
    {
        public 婚姻(特征 龙傲天) : base(龙傲天) { }
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