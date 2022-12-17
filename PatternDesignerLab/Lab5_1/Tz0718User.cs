using System;

namespace Lab5_1
{
    public class Tz0718User
    {
        public Tz0718AbstractState userLevel
        {
            get;
            set;
        }
        private Tz0718Subject bookStoreSubkect;
        private string name;
        private double score;
        private double payMoney;
        public Tz0718User(string name)
        {
            this.name = name;
            score = 0;
            payMoney = 0;
            this.userLevel = new Tz0718Ordinary(this);
        }
        public void BuyBook(double amount)
        {
            score += userLevel.ChangeCredit(amount);
            double realAmount = userLevel.CalcRealAmount(amount);
            payMoney += realAmount;
            userLevel.StateCheck();
            System.Console.WriteLine("{0}花费了:{1}元,积分为:{2},等级为:{3}", name, payMoney, score, userLevel.GetLevelName());
        }

        public void PurchaseGift(double giftScore)
        {
            if (score >= giftScore)
            {
                score -= giftScore;
                System.Console.WriteLine("{0}花费了：{1}积分兑换了购物劵，剩余积分为：{2}", name, giftScore, score);
            }
            else
            {
                Console.WriteLine("积分不足");
            }
        }

        public double GetScore()
        {
            return score;
        }

        public void setUserlevel(Tz0718AbstractState state)
        {
            this.userLevel = state;
        }

        public void Response(string msg)
        {
            System.Console.WriteLine("{0}收到了消息：{1}", name, msg);
        }

        public void SetBookStoreSubject(Tz0718Subject subject)
        {
            this.bookStoreSubkect = subject;
        }
    }
}