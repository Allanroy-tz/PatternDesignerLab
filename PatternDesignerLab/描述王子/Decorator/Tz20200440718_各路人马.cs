using System;
using System.Collections.Generic;
using System.Text;

namespace 描述王子
{
    abstract public class Tz20200440718_各路人马 : Tz20200440718_特征
    {
        Tz20200440718_特征 搜集对象;
        public Tz20200440718_各路人马(Tz20200440718_特征 龙傲天)
        {
            搜集对象 = 龙傲天;
        }

        public override string 描述()
        {
            return 搜集对象.描述();
        }
    }
}