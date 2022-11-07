using System;
using System.Collections.Generic;
using System.Text;

namespace The_Computer
{
    public class Tz20200440718_ComputerBuilder02 : Tz20200440718_ComputerAbstractBuilder
    {
        public override void BuildCDROM()
        {
            computer.CDROM = "CDROM_99";
        }

        public override void BuildCPU()
        {
            computer.CPU = "CPU__86";
        }

        public override void BuildGPU()
        {
            computer.GPU = "GPU__43";
        }
        public override void BuildMemory()
        {
            computer.Memory = "Memory__9999";
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