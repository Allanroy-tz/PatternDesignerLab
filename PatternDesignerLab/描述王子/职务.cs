using System;
using System.Collections.Generic;
using System.Text;

namespace 描述王子
{
    public class 职务 : 各路人马
    {
        public 职务(特征 龙傲天) : base(龙傲天) { }
        public string 获取职务()
        {
            return "职务：管家\n";
        }
        public override string 描述()
        {
            string tz = base.描述();
            tz += 获取职务();
            return tz;
        }
    }
}