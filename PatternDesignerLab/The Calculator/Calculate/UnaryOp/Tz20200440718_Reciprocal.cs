using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Calculator
{
    public class Tz20200440718_Reciprocal : Tz20200440718_IUnaryOp
    {
        /// <summary>
        /// 求倒数
        /// </summary>
        /// <param name="a">底数</param>
        /// <returns>1/a</returns>
        public double Calculate(double a)
        {
            return 1 / a;
        }
    }
}