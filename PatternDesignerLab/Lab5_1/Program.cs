using System;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tz0718User user1 = new Tz0718User("张三"); Tz0718User user2 = new Tz0718User("李四");
            Tz0718Subject bookStoreSubject = new Tz0718BookStoreConcretSubject();
            bookStoreSubject.AddUser(user2);
            bookStoreSubject.AddUser(user1);
            user1.BuyBook(amount: 500);
            user1.PurchaseGift(giftScore: 500); user1.BuyBook(amount: 500);
            user1.PurchaseGift(giftScore: 15);
            bookStoreSubject.Notify("猜书赢钱活动开始啦");

        }
    }
}
