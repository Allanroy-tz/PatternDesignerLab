using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
    public class Tz0718Silver : Tz0718AbstractState
    {
        public Tz0718Silver(Tz0718User user)
        {
            User = user;
            SetLevelName("白银会员");
        }
        public override double CalcRealAmount(double amount)
        {
            return amount * 0.9;
        }

        public override double ChangeCredit(double amount)
        {
            return amount / 10;
        }

        public override void StateCheck()
        {
            if (User.GetScore() < 10)
                User.setUserlevel(new Tz0718Ordinary(User));
            else if (User.GetScore() >= 10 && User.GetScore() < 50) { }
            else if (User.GetScore() >= 50 && User.GetScore() < 100)
                User.setUserlevel(new Tz0718GoldUser(User));
            else if (User.GetScore() >= 100)
                User.setUserlevel(new Tz0718Diamond(User));
        }
    }
}