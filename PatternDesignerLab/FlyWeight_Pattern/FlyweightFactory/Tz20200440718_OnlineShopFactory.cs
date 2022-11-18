using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight_Pattern
{
    public class Tz20200440718_OnlineShopFactory
    {
        private Dictionary<string, Tz20200440718_OnlineShop> shopDic;
        public Tz20200440718_OnlineShopFactory()
        {
            shopDic = new Dictionary<string, Tz20200440718_OnlineShop>();
            Tz20200440718_OnlineShop shop01 = new Tz20200440718_TemplateShop01("一号风格");
            AddTemp("一号",shop01);
            Tz20200440718_OnlineShop shop02 = new Tz20200440718_TemplateShop02("二号风格");
            AddTemp("二号",shop02);
            Tz20200440718_OnlineShop shop03 = new Tz20200440718_TemplateShop03("三号风格");
            AddTemp("三号",shop03);
        }
        public void RemoveTemp(string styleName)
        {
            shopDic.Remove(styleName);
        }
        public void AddTemp(string styleName,Tz20200440718_OnlineShop templateShop)
        {
            shopDic.Add(styleName, templateShop);
        }
        public Tz20200440718_OnlineShop GetTemp(string styleName)
        {
            return shopDic[styleName];
        }
    }
}