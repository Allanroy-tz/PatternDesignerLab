using System;
using System.Collections.Generic;
using System.Text;

namespace The_Computer
{
    public class Tz20200440718_ComputerBuilder01 : Tz20200440718_ComputerAbstractBuilder
    {
        public override void BuildCDROM()
        {
            computer.CDROM = "null";
        }

        public override void BuildCPU()
        {
            computer.CPU = "CPU__01";
        }

        public override void BuildGPU()
        {
            computer.GPU = "GPU__01";
        }
        public override void BuildMemory()
        {
            computer.Memory = "Memory__02";
        }
        public override void BuildKeyboardMouse()
        {
            computer.KeyboardMouse = "KeyboardMouse__09";
        }

        public override void BuildMonitor()
        {
            computer.Monitor = "Monitor__09";
        }
    }
}