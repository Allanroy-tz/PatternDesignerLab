using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Calculator
{
    class Tz20200440718_OpFactory
    {
        /// <summary>
        /// 获取二元计算类
        /// </summary>
        /// <param name="OpName">计算的类型</param>
        /// <returns></returns>
        public Tz20200440718_IBinaryOp GetBinaryOp(EBinaryOp OpName)
        {
            switch (OpName)
            {
                case EBinaryOp.Add: return new Tz20200440718_Add();
                case EBinaryOp.Sub: return new Tz20200440718_Subtract();
                case EBinaryOp.Mul: return new Tz20200440718_Multiply();
                case EBinaryOp.Div: return new Tz20200440718_Division();
                case EBinaryOp.Log: return new Tz20200440718_Log();
                case EBinaryOp.Pow: return new Tz20200440718_Pow();
            }
            return null;
        }
        public Tz20200440718_IUnaryOp GetUnaryOp(EUnaryOp OpName)
        {
            switch (OpName)
            {
                case EUnaryOp.Opp: return new Tz20200440718_Opp();
                case EUnaryOp.Abs: return new Tz20200440718_Abs();
                case EUnaryOp.Reciprocal: return new Tz20200440718_Reciprocal();
                case EUnaryOp.Sqrt: return new Tz20200440718_Sqrt();
            }
            return null;
        }

    }
}
