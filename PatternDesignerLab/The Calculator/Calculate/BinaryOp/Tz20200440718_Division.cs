using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Calculator
{
    public class Tz20200440718_Division : Tz20200440718_IBinaryOp
    {
        /// <summary>
        /// 两数相除
        /// </summary>
        /// <param name="a">被除数</param>
        /// <param name="b">除数</param>
        /// <returns>a/b</returns>
        public double Calculate(double a, double b)
        {
            return (double) a / b;
        }
    }
}