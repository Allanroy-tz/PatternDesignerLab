using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Calculator
{
    public class Tz20200440718_Log : Tz20200440718_IBinaryOp
    {
        /// <summary>
        /// 对数运算
        /// </summary>
        /// <param name="a">底数</param>
        /// <param name="b">真数</param>
        /// <returns>Loga(b)</returns>
        public double Calculate(double a, double b)
        {
            return (double)Math.Log(a, b);
        }
    }
}