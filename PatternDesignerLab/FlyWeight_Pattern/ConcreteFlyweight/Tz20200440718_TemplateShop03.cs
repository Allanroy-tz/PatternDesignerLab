using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight_Pattern
{
    public class Tz20200440718_TemplateShop03 : Tz20200440718_OnlineShop
    {
        string styleName;
        public Tz20200440718_TemplateShop03(string name) { styleName = name; }
        public override void Build(Tz20200440718_Logo logo)
        {
            System.Console.WriteLine("“{0}”：一号模版，风格：{1}，Logo：“{2}”", shopName, styleName, logo.GetLogo());
        }
    }
}