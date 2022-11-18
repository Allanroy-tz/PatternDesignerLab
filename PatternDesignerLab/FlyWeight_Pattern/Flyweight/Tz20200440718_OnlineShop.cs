using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight_Pattern
{
    public abstract class Tz20200440718_OnlineShop
    {
        /// <summary>
        /// 网店的名字
        /// </summary>
        protected string shopName;
        public string name { get { return shopName; } }
        public abstract void Build(Tz20200440718_Logo loge);
        public void SetShopName(string name)
        {
            shopName = name;
        }
    }
}