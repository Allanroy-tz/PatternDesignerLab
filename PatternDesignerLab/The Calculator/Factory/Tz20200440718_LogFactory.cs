using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Calculator
{
    public class Tz20200440718_LogFactory
    {
        public  Tz20200440718_LogOp GetOp(string name)
        {
            if (name == "Doc")
                return new Tz20200440718_DocLog();
            if (name == "DB")
                return new Tz20200440718_DataBaseLog();
            return null;
        }
    }
}