using System;
using System.Collections.Generic;
using System.Text;

namespace 描述王子
{
    public class 人品 : 各路人马
    {
        public 人品(特征 龙傲天) : base(龙傲天) { }
        public string 搜集人品()
        {
            return "人品：极品\n";
        }
        public override string 描述()
        {
            string tz = base.描述();
            tz += 搜集人品();
            return tz;
        }
    }
}