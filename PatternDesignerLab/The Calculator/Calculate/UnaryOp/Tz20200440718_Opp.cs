using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Calculator
{
    public class Tz20200440718_Opp : Tz20200440718_IUnaryOp
    {
        /// <summary>
        /// 取反
        /// </summary>
        /// <param name="a">操作数</param>
        /// <returns>~a</returns>
        public double Calculate(double a)
        {
            return ~(int)a;
        }
    }
}