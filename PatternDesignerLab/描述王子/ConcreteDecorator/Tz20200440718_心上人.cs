namespace 描述王子
{
    public class Tz20200440718_心上人 : Tz20200440718_各路人马
    {
        public Tz20200440718_心上人(Tz20200440718_特征 龙傲天) : base(龙傲天) { }
        string 获取心上人信息()
        {
            return "心上人：刘ber~\n";
        }
        public override string 描述()
        {
            string tz = base.描述();
            tz += 获取心上人信息();
            return tz;
        }
    }
}