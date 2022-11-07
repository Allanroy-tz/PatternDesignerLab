using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Calculator
{
    public class Tz20200440718_Abs : Tz20200440718_IUnaryOp
    {
        /// <summary>
        /// 取绝对值
        /// </summary>
        /// <param name="a">操作数</param>
        /// <returns>Abs(a)</returns>
        public double Calculate(double a)
        {
            return Math.Abs(a);
        }
    }
}