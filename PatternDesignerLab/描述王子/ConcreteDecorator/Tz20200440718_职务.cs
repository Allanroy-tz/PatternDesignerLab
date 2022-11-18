using System;
using System.Collections.Generic;
using System.Text;

namespace 描述王子
{
    public class Tz20200440718_职务 : Tz20200440718_各路人马
    {
        public Tz20200440718_职务(Tz20200440718_特征 龙傲天) : base(龙傲天) { }
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