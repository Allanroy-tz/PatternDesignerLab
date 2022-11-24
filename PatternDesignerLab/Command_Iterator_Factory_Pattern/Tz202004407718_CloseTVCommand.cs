using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public class Tz202004407718_CloseTVCommand : Tz202004407718_ICommand
    {
        private Tz202004407718_ITelevision tv;
        public void Execute()
        {
            tv.Close();
        }

        public void Set(object ob)
        {
            tv = (Tz202004407718_ITelevision)ob;
        }
    }
}