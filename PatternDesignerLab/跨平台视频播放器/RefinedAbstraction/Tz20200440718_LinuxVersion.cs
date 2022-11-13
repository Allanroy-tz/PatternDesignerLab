using System;
using System.Collections.Generic;
using System.Text;

namespace 跨平台视频播放器
{
    public class Tz20200440718_LinuxVersion : Tz20200440718_OperatingSystemVersion
    {
        public override void Play(string fileName)
        {
            string os = "Linux";
            vf.Decode(os, fileName);
        }
    }
}