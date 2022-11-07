using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace The_Web
{
    public class Singleton
    {
        private static Singleton instance=new Singleton();
        private Singleton() { }
        public static Singleton Instance { get { return instance; } }
        int count = 0;
        public int Add()
        {
             return ++count;
        }
    }
}