
namespace FlyWeight_Pattern
{
    public class Tz20200440718_TemplateShop01 : Tz20200440718_OnlineShop
    {
        string styleName;
        public Tz20200440718_TemplateShop01(string name){ styleName = name; }
        public override void Build(Tz20200440718_Logo logo)
        {
            System.Console.WriteLine("“{0}”：一号模版，风格：{1}，Logo：“{2}”", shopName,styleName, logo.GetLogo());
        }
    }
}