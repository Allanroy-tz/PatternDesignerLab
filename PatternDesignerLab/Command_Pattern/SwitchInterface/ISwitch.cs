using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public interface ISwitch
    {
        public void Open();
        public void Close();
    }
}