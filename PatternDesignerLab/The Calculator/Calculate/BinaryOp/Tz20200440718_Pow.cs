using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Calculator
{
    public class Tz20200440718_Pow : Tz20200440718_IBinaryOp
    {
        /// <summary>
        /// 指数运算
        /// </summary>
        /// <param name="a">底数</param>
        /// <param name="b">指数</param>
        /// <returns>a**b</returns>
        public double Calculate(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}