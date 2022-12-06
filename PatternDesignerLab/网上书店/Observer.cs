using System;
using System.Collections.Generic;
using System.Text;

namespace 网上书店
{
    public interface Observer
    {
        void Update(string msg);
    }
}