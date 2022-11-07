using System;
using System.Collections.Generic;
using System.Text;

namespace The_Computer
{
    public class Tz20200440718_ComputerBuilder03 : Tz20200440718_ComputerAbstractBuilder
    {
        public override void BuildCDROM()
        {
            computer.CDROM = "CDROM_00";
        }

        public override void BuildCPU()
        {
            computer.CPU = "CPU__100";
        }

        public override void BuildGPU()
        {
            computer.GPU = "GPU__100";
        }
        public override void BuildMemory()
        {
            computer.Memory = "Memory__100";
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