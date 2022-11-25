namespace State_Pattern
{
    public class ProfessionalState : AbstratcState
    {
        public ProfessionalState(AbstratcState state) { rank = "高手级"; player = state.player; CheckState(); }
        public override void CheckState()
        {
            if (player.point>=500)
            {
                player.SetState(new FinalState(this));
                System.Console.WriteLine("{0}从高手级升级为骨灰级",player.name);
            }
            if(player.point<100)
            {
                player.SetState(new SecondaryState(this));
                System.Console.WriteLine("{0}从高手级降级为熟练级",player.name);
            }
        }
        public override void DoubleScore()
        {
            System.Console.WriteLine("{0}使用了加倍功能", player.name);
            System.Console.WriteLine("{0}的积分由{1}翻倍为{2}", player.name, player.point, player.point *= 2);
        }
        public override void ChangeCards()
        {

            System.Console.WriteLine("{0}换牌成功",player.name);
        }
    }
}