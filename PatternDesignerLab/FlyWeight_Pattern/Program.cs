using System;

namespace FlyWeight_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tz20200440718_Logo logo = new Tz20200440718_Logo("一个LOGO");
            Tz20200440718_OnlineShopFactory shopFactory = new Tz20200440718_OnlineShopFactory();
            Tz20200440718_OnlineShop 王五的网店 =shopFactory.GetTemp("一号");
            王五的网店.SetShopName("店主叫王五");
            王五的网店.Build(logo);
            Tz20200440718_OnlineShop 李四的网店 = shopFactory.GetTemp("二号");
            李四的网店.SetShopName("店主叫李四");
            李四的网店.Build(logo);
            Tz20200440718_OnlineShop 张三的网店 = shopFactory.GetTemp("三号");
            张三的网店.SetShopName("店主叫李四");
            张三的网店.Build(logo);
        }
    }
}
