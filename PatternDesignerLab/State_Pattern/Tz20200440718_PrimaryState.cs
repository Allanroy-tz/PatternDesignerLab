
namespace State_Pattern
{
    public class Tz20200440718_PrimaryState : Tz20200440718_AbstratcState
    {
        public Tz20200440718_PrimaryState(Tz20200440718_AbstratcState state)
        {
            rank = "人门级";
            player = state.player;
            CheckState();
        }
        public Tz20200440718_PrimaryState(Tz20200440718_Player player)
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
                player.SetState(new Tz20200440718_SecondaryState(this));
            }

        }
    }
}