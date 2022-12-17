using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
    public abstract class Tz0718AbstractState
    {
        private string levelName;
        protected Tz0718User User
        {
            get;
            set;
        }
        public abstract void StateCheck();

        public abstract double CalcRealAmount(double amount);

        public abstract double ChangeCredit(double amount);

        public void SetLevelName(string name)
        {
            this.levelName = name;
        }
        public string GetLevelName()
        {
            return levelName;
        }
    }
}