using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public class Tz202004407718_PreviousChannelCommand : Tz202004407718_ICommand
    {
        private Tz202004407718_ITVIterator iterator;
        public void Execute()
        {
            iterator.Previous();
            iterator.CurrentChannel();
        }
        public void Set(object ob)
        {
            iterator = (Tz202004407718_ITVIterator)ob;
        }
    }
}