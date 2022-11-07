using System;
using System.Collections.Generic;
using System.Text;

namespace The_Computer
{
    public abstract class Tz20200440718_ComputerAbstractBuilder
    {
        public Tz20200440718_Computer computer=new Tz20200440718_Computer();

        public abstract void BuildCPU();

        public abstract void BuildGPU();

        public abstract void BuildMemory();

        public abstract void BuildMonitor();

        public abstract void BuildCDROM();

        public abstract void BuildKeyboardMouse();
        public Tz20200440718_Computer GetComputer()
        {
            return this.computer;
        }
    }
}