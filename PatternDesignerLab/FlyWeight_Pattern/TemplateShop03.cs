using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight_Pattern
{
    public class TemplateShop03 : OnlineShop
    {
        string templateName;
        public TemplateShop03(string name) { templateName = name; }
        public override void Build(Logo loge)
        {
            System.Console.WriteLine("“{0}”：三号风格，Logo：“{1}”", shopName, loge.GetLogo());
        }
    }
}