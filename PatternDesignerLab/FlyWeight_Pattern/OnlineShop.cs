using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight_Pattern
{
    public abstract class OnlineShop
    {
        /// <summary>
        /// 网店的名字
        /// </summary>
        protected string shopName;
        public string name { get { return shopName; } }
        public abstract void Build(Logo loge);
        public void SetShopName(string name)
        {
            shopName = name;
        }
    }
}