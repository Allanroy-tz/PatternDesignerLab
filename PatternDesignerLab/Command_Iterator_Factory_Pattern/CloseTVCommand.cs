using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public class CloseTVCommand : ICommand
    {
        private ITelevision tv;
        public void Execute()
        {
            tv.Close();
        }

        public void Set(object ob)
        {
            tv = (ITelevision)ob;
        }
    }
}