namespace State_Pattern
{
    public class Player
    {
        public int point { get; set; }
        public string name;
        protected AbstratcState state
        {
            get;
            set;
        }
        public Player(string name)
        {
            this.name = name; state = new PrimaryState(this);
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
        public void SetState(AbstratcState state)
        {
            this.state = state;
        }
        public string GetRank()
        {
            return state.GetRank();
        }
    }
}