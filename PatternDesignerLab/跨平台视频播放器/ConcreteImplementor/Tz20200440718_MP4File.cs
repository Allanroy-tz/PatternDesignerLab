﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 跨平台视频播放器
{
    public class Tz20200440718_MP4File : Tz20200440718_IVideoFile
    {
        public void Decode(string osType, string fileName)
        {
            System.Console.WriteLine("操作系统：“{0}”，MP4类型：“{1}”", osType, fileName);
        }
    }
}