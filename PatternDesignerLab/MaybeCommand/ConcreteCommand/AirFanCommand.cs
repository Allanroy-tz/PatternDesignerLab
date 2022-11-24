using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public class AirFanCommand : AbstractCommand<AirFan>
    {
        public AirFanCommand()
        {
            AirFan airFan01 = new AirFan(01);
            AirFan airFan02 = new AirFan(02);
            AirFan airFan03 = new AirFan(03);
        }
    }
}