using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Observer customer01 = new Customer("张三");
            Observer customer02 = new Customer("李四");
            Observer customer03 = new Customer("王五");

            Subject subject01 = new HuaweiShop();
            subject01.Attach(customer01);
            subject01.Attach(customer02);
            subject01.Attach(customer03);

            subject01.Notify();
        }
    }
}
