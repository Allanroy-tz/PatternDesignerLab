using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Calculator
{
    public class Tz20200440718_Sqrt : Tz20200440718_IUnaryOp
    {
        /// <summary>
        /// 计算平方根
        /// </summary>
        /// <param name="a">底数</param>
        /// <returns>|a|</returns>
        public double Calculate(double a)
        {
            return Math.Sqrt(a);
        }
    }
}