using System;
using System.Collections.Generic;
using System.Text;

namespace 跨平台视频播放器
{
    public class Tz20200440718_HarmonyOsVersion : Tz20200440718_OperatingSystemVersion
    {
        public override void Play(string fileName)
        {
            string os = "HarmonyOs";
            vf.Decode(os, fileName);
        }
    }
}