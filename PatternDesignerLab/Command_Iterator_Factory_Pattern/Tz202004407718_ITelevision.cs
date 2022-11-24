using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public interface Tz202004407718_ITelevision
    {
        Tz202004407718_ITVIterator CreateIterator();
        void Open();
        void Close();
        void SetChannelIndex(int i);
    }
}