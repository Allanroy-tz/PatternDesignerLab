using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight_Pattern
{
    public class OnlineShopFactory
    {
        private Dictionary<string, OnlineShop> shopDic;
        public OnlineShopFactory()
        {
            shopDic = new Dictionary<string, OnlineShop>();
            OnlineShop shop01 = new TemplateShop03("一号网店模版");
            AddTemp("一号",shop01);
            OnlineShop shop02 = new TemplateShop01("二号网店模版");
            AddTemp("二号",shop02);
            OnlineShop shop03 = new TemplateShop03("三号网店模版");
            AddTemp("三号",shop03);
        }
        public void RemoveTemp(string tempName)
        {
            shopDic.Remove(tempName);
        }
        public void AddTemp(string tempName,OnlineShop templateShop)
        {
            shopDic.Add(tempName, templateShop);
        }
        public OnlineShop GetTemp(string styleName)
        {
            return shopDic[styleName];
        }
    }
}