namespace The_Calculator
{
    public class Tz20200440718_Add : Tz20200440718_IBinaryOp
    {
        /// <summary>
        /// 两个数相加
        /// </summary>
        /// <param name="a">第一个数</param>
        /// <param name="b">第二个数</param>
        /// <returns>a+b</returns>
        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }
}