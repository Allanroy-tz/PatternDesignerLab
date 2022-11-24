using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public class Tz20200440718_OpenCommand : Tz20200440718_ICommnad
    {
        Tz20200440718_ISwitch @switch;
        public Tz20200440718_OpenCommand(Tz20200440718_ISwitch @switch) { this.@switch = @switch; }
        public void Execute()
        {
            @switch.Open();
        }
    }
}