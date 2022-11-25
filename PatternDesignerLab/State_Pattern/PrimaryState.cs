
namespace State_Pattern
{
    public class PrimaryState : AbstratcState
    {
        public PrimaryState(AbstratcState state)
        {
            rank = "人门级";
            player = state.player;
            CheckState();
        }
        public PrimaryState(Player player)
        {
            rank = "人门级";
            this.player = player;
            CheckState();
        }
        public override void CheckState()
        {
            if (player.point >= 20)
            {
                System.Console.WriteLine("{0}从入门级升级为熟练级",player.name);
                player.SetState(new SecondaryState(this));
            }

        }
    }
}