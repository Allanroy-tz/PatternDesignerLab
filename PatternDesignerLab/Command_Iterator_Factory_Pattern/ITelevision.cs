using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public interface ITelevision
    {
        ITVIterator CreateIterator();
        void Open();
        void Close();
        void SetChannelIndex(int i);
    }
}