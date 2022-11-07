using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Calculator
{
    public class Tz20200440718_Subtract : Tz20200440718_IBinaryOp
    {
        /// <summary>
        /// 减法运算
        /// </summary>
        /// <param name="a">被减数</param>
        /// <param name="b">减数</param>
        /// <returns>a-b</returns>
        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }
}