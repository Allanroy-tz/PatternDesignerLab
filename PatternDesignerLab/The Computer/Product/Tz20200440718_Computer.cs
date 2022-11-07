using System;
using System.Collections.Generic;
using System.Text;

namespace The_Computer
{
    public class Tz20200440718_Computer
    {
        public string GPU { get; set; }
        public string CPU { get; set; }
        public string Memory { get; set; }
        public string Monitor { get; set; }
        public string CDROM { get; set; }
        public string KeyboardMouse { get; set; }

        public  void show()
        {
            System.Console.WriteLine("CPU:"+CPU);
            System.Console.WriteLine("Memory:" + Memory);
            System.Console.WriteLine("Monitor:" + Monitor);
            System.Console.WriteLine("GPU:" + GPU);
            System.Console.WriteLine("CDROM:" + CDROM);
            System.Console.WriteLine("KeyboardMouse:" + KeyboardMouse);

        }
    }
}