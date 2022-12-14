using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public interface Tz202004407718_ITVIterator
    {
        void Next();
        void Previous();
        bool IsFirst();
        bool IsLast();
        Object CurrentChannel();
        void SetChannel(int i);
    }
}