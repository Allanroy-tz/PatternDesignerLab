using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight_Pattern
{
    public class Logo
    {
        string logo;
        public Logo(string logo) { this.logo = logo; }
        public string GetLogo()
        {
            return logo;
        }
    }
    
}