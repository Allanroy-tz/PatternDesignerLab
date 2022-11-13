using System;
using System.Collections.Generic;
using System.Text;

namespace 跨平台视频播放器
{
    public class Tz20200440718_MPEGAdapter : Tz20200440718_MPEGFile, Tz20200440718_IVideoFile
    {
        public void Decode(string osType, string fileName)
        {
            base.MPEGDcode(osType, fileName);
        }
    }
}