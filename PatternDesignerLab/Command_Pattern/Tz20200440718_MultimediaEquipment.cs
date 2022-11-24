using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public class Tz20200440718_MultimediaEquipment : Tz20200440718_ISwitch
    {
        int num;
        public  Tz20200440718_MultimediaEquipment(int num) { this.num = num; }
        public void Close()
        {
            System.Console.WriteLine("多媒体设备编号：“{0}”关闭！", num);
        }

        public void Open()
        {
            System.Console.WriteLine("多媒体设备编号：“{0}”打开！", num);
        }
    }
}