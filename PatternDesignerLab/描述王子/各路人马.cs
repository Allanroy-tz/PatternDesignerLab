using System;
using System.Collections.Generic;
using System.Text;

namespace 描述王子
{
    abstract public class 各路人马 : 特征
    {
        特征 搜集对象;
        public 各路人马(特征 龙傲天)
        {
            搜集对象 = 龙傲天;
        }

        public override string 描述()
        {
            return 搜集对象.描述();
        }
    }
}