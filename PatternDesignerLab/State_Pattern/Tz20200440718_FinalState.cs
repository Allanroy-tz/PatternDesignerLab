

namespace State_Pattern
{
    public class Tz20200440718_FinalState : Tz20200440718_AbstratcState
    {
        public Tz20200440718_FinalState(Tz20200440718_AbstratcState state) { rank = "骨灰级";player = state.player; CheckState(); }
        public override void CheckState()
        {
            if (player.point < 500)
            {
                System.Console.WriteLine("从骨灰级降级为高手级");
                player.SetState(new Tz20200440718_ProfessionalState(this));
            }
                
        }
        public override void DoubleScore()
        {
            System.Console.WriteLine("{0}使用了加倍功能", player.name);
            System.Console.WriteLine("{0}的积分由{1}翻倍为{2}", player.name, player.point, player.point *= 2);
        }
        public override void ChangeCards()
        {

            System.Console.WriteLine("{0}换牌成功", player.name);
        }
        public override void PeekCards()
        {
            System.Console.WriteLine("{0}偷看成功",player.name);
        }
    }
}