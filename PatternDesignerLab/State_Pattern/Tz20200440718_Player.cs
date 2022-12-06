namespace State_Pattern
{
    public class Tz20200440718_Player
    {
        public int point { get; set; }
        public string name;
        protected Tz20200440718_AbstratcState state
        {
            get;
            set;
        }
        public Tz20200440718_Player(string name)
        {
            this.name = name; state = new Tz20200440718_PrimaryState(this);
            state.player = this;
        }

        public void Win()
        {
            state.Win();
            
        }
        public void Lose()
        {
            state.Lose();
            System.Console.WriteLine("{0}输了，积分为{1}", name, point);
        }
        public void CheckState()
        {
            state.CheckState();
        }
        public void DoubleScore()
        {
            state.DoubleScore();
        }
        public void ChangeCards()
        {
            state.ChangeCards();
        }
        public void PeekCards()
        {
            state.PeekCards();
        }
        public void SetState(Tz20200440718_AbstratcState state)
        {
            this.state = state;
        }
        public string GetRank()
        {
            return state.GetRank();
        }
    }
}