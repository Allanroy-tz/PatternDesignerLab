using System;

namespace 描述王子
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string 龙傲天的描述 = "";
            Tz20200440718_特征 龙傲天 = new Tz20200440718_王子();
            Tz20200440718_特征 职务情况 = new Tz20200440718_职务(龙傲天);
            Tz20200440718_特征 婚姻情况 =new Tz20200440718_婚姻(职务情况);
            Tz20200440718_特征 家庭背景情况 = new Tz20200440718_家庭背景(婚姻情况);
            Tz20200440718_特征 人品情况 = new Tz20200440718_人品(家庭背景情况);
            Tz20200440718_特征 心上人情况 = new Tz20200440718_心上人(人品情况);

            龙傲天的描述 += 心上人情况.描述();


            System.Console.WriteLine(龙傲天的描述);
        }
    }
}
