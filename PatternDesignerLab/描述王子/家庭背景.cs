using System;
using System.Collections.Generic;
using System.Text;

namespace 描述王子
{
    public class 家庭背景 : 各路人马
    {
        public 家庭背景(特征 龙傲天) : base(龙傲天) { }
        public string 调查家庭背景()
        {
            return "家庭背景：不详？！绝密？！\n";
        }
        public override string 描述()
        {
            string tz = base.描述();
            tz += 调查家庭背景();
            return tz;
        }
    }
}