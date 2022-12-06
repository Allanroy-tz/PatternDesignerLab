namespace State_Pattern
{
    public abstract class Tz20200440718_AbstratcState
    {
        protected string rank;
        public Tz20200440718_Player player
        {
            get;
            set;
        }
        public string GetRank() { return rank; }
        public void Win()
        {
            System.Console.WriteLine("{0}赢了，加10分，积分为{1}", player.name, player.point);
            player.point += 10;
            CheckState();
        }

        public void Lose()
        {
            System.Console.WriteLine("{0}输了，扣5分，积分为{1}", player.name, player.point);
            player.point -= 5;
            CheckState();
        }

        public abstract void CheckState();

        public virtual void DoubleScore()
        {
            System.Console.WriteLine("{0}{1}没有DoubleScore的资格", player.GetRank(), player.name);
        }

        public virtual void ChangeCards()
        {
            System.Console.WriteLine("{0}{1}没有ChangeCards的资格", player.GetRank(), player.name);
        }

        public virtual void PeekCards()
        {
            System.Console.WriteLine("{0}{1}没有PeekCards的资格", player.GetRank(), player.name);
        }
    }
}