using System;

namespace 描述王子
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string 龙傲天的描述 = "";
            特征 龙傲天 = new 王子();
            特征 职务情况 = new 职务(龙傲天);
            特征 婚姻情况 =new 婚姻(职务情况);
            特征 家庭背景情况 = new 家庭背景(婚姻情况);
            特征 人品情况 = new 人品(家庭背景情况);
            特征 心上人情况 = new 心上人(人品情况);

            龙傲天的描述 += 心上人情况.描述();


            System.Console.WriteLine(龙傲天的描述);
        }
    }
}
