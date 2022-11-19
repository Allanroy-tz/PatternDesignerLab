using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public class PreviousChannelCommand : ICommand
    {
        private ITVIterator iterator;
        public void Execute()
        {
            iterator.Previous();
            iterator.CurrentChannel();
        }
        public void Set(object ob)
        {
            iterator = (ITVIterator)ob;
        }
    }
}