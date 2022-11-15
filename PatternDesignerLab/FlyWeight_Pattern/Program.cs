using System;

namespace FlyWeight_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Logo logo = new Logo("一个LOGO");
            OnlineShopFactory shopFactory = new OnlineShopFactory();
            OnlineShop 王五的网店 =shopFactory.GetTemp("一号");
            王五的网店.SetShopName("店主叫王五");
            王五的网店.Build(logo);
            OnlineShop 李四的网店 = shopFactory.GetTemp("二号");
            王五的网店.SetShopName("店主叫李四");
            王五的网店.Build(logo);
            OnlineShop 张三的网店 = shopFactory.GetTemp("三号");
            王五的网店.SetShopName("店主叫李四");
            王五的网店.Build(logo);
        }
    }
}
