namespace 描述王子
{
    public class 心上人 : 各路人马
    {
        public 心上人(特征 龙傲天) : base(龙傲天) { }
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