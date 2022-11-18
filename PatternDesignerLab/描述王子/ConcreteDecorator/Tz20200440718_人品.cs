using System;
using System.Collections.Generic;
using System.Text;

namespace 描述王子
{
    public class Tz20200440718_人品 : Tz20200440718_各路人马
    {
        public Tz20200440718_人品(Tz20200440718_特征 龙傲天) : base(龙傲天) { }
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