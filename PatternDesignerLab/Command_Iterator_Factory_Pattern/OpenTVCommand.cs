using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public class OpenTVCommand : ICommand
    {
        private ITelevision tv;
        public void Execute()
        {
            tv.Open();
        }

        public void Set(object ob)
        {
            tv = (ITelevision)ob;
        }
    }
}