
namespace FlyWeight_Pattern
{
    public class TemplateShop01 : OnlineShop
    {
        string templateName;
        public TemplateShop01(string name){ templateName = name; }
        public override void Build(Logo loge)
        {
            System.Console.WriteLine("“{0}”：一号风格，Logo：“{1}”", shopName, loge.GetLogo());
        }
    }
}