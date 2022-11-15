
namespace FlyWeight_Pattern
{
    public class TemplateShop02 : OnlineShop
    {
        string templateName;
        public TemplateShop02(string name) { templateName = name; }
        public override void Build(Logo loge)
        {
            System.Console.WriteLine("“{0}”：二号风格，Logo：“{1}”", shopName, loge.GetLogo());
        }
    }
}