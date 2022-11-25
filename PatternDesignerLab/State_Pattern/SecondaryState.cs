

namespace State_Pattern
{
    public class SecondaryState : AbstratcState
    {
        public SecondaryState(AbstratcState state) { rank = "熟练级";player = state.player; CheckState(); }
        public override void CheckState()
        {
            if (player.point >= 100)
            {
                System.Console.WriteLine("{0}从熟练级升级为高手级",player.name);
                player.SetState(new ProfessionalState(this));
            }
                
            if (player.point < 20)
            {
                System.Console.WriteLine("{0}从熟练级降级为入门级",player.name);
                player.SetState(new PrimaryState(this));
            }
        }
        public override void DoubleScore()
        {
            System.Console.WriteLine("{0}使用了加倍功能",player.name);
            System.Console.WriteLine("{0}的积分由{1}翻倍为{2}", player.name,player.point,player.point*=2);
        }
    }
}