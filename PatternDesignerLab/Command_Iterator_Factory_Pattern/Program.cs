
namespace Command_Iterator_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            System.Console.WriteLine("----------------------测试一号品牌电视----------------------");
            Tz202004407718_TVFactory tVFactory = new Tz202004407718_TVFactory();
            Tz202004407718_ITelevision tv01 = tVFactory.GetTV("Brand01");
            Tz202004407718_TVController tv01Controller = tVFactory.GetTVController("Brand01");
            tv01Controller.SetTV(tv01);
            tv01Controller.NextChannel();
            tv01Controller.NextChannel();
            tv01Controller.NextChannel();
            Tz202004407718_TVController tv01Controller01 = tVFactory.GetTVController("Brand01");
            tv01Controller01.SetTV(tv01);
            tv01Controller01.NextChannel();
            System.Console.WriteLine("----------------------测试二号品牌电视----------------------");
            Tz202004407718_ITelevision tv02 = tVFactory.GetTV("Brand02");
            Tz202004407718_TVController tv02Controller = tVFactory.GetTVController("Brand02");
            tv01Controller.SetTV(tv02);
            tv01Controller.NextChannel();
            tv01Controller.NextChannel();
            tv01Controller.NextChannel();
            Tz202004407718_TVController tv02Controller01 = tVFactory.GetTVController("Brand02");
            tv01Controller01.SetTV(tv02);
            tv01Controller01.NextChannel();
            System.Console.WriteLine("----------------------测试三号品牌电视----------------------");
            Tz202004407718_ITelevision tv03 = tVFactory.GetTV("Brand03");
            Tz202004407718_TVController tv03Controller = tVFactory.GetTVController("Brand03");
            tv01Controller.SetTV(tv01);
            tv01Controller.NextChannel();
            tv01Controller.NextChannel();
            tv01Controller.NextChannel();
            Tz202004407718_TVController tv03Controller01 = tVFactory.GetTVController("Brand03");
            tv01Controller01.SetTV(tv01);
            tv01Controller01.NextChannel();

        }
    }
}
