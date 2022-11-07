
using System;
using System.Collections.Generic;
using System.Text;

namespace The_Computer
{
    public class Tz20200440718_Assembler
    {
        private Tz20200440718_ComputerAbstractBuilder builder;
        public void SetBuilder(Tz20200440718_ComputerAbstractBuilder builder)
        {
            this.builder = builder;
        }

        public Tz20200440718_Computer construct()
        {
            builder.BuildCDROM();
            builder.BuildCPU();
            builder.BuildGPU();
            builder.BuildKeyboardMouse();
            builder.BuildMemory();
            builder.BuildMonitor();
            return builder.GetComputer();
        }
    }
}