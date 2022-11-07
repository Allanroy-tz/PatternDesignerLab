using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Calculator
{
    public class Tz20200440718_Multiply : Tz20200440718_IBinaryOp
    {
        /// <summary>
        /// 乘法运算
        /// </summary>
        /// <param name="a">被乘数</param>
        /// <param name="b">乘数</param>
        /// <returns>a*b</returns>
        public double Calculate(double a, double b)
        {
            return (double)a * b;
        }
    }
}