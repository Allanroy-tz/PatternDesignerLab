using System;

namespace Observer_Pattern
{
    class Tz20200440718_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tz20200440718_Observer customer01 = new Tz20200440718_Customer("张三");
            Tz20200440718_Observer customer02 = new Tz20200440718_Customer("李四");
            Tz20200440718_Observer customer03 = new Tz20200440718_Customer("王五");

            Tz20200440718_Subject subject01 = new Tz20200440718_HuaweiShop();
            subject01.Attach(customer01);
            subject01.Attach(customer02);
            subject01.Attach(customer03);

            subject01.Notify();
        }
    }
}
