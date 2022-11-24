using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public class AirConditionerCommand : AbstractCommand<AirConditioner>
    {
        public AirConditionerCommand()
        {
            AirConditioner airConditioner01 = new AirConditioner(01);
            AirConditioner airConditioner02 = new AirConditioner(02);
            AirConditioner airConditioner03 = new AirConditioner(03);
            AirConditioner airConditioner04 = new AirConditioner(04);
            AddObject(01, airConditioner01);
            AddObject(02, airConditioner02);
            AddObject(03, airConditioner03);
            AddObject(04, airConditioner04);
        }
    }
}