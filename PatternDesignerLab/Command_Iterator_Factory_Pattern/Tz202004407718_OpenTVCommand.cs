using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public class Tz202004407718_OpenTVCommand : Tz202004407718_ICommand
    {
        private Tz202004407718_ITelevision tv;
        public void Execute()
        {
            tv.Open();
        }
        public void Set(object ob)
        {
            tv = (Tz202004407718_ITelevision)ob;
        }
    }
}