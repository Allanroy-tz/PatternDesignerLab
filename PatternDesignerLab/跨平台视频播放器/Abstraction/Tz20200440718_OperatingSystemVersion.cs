using System;
using System.Collections.Generic;
using System.Text;

namespace 跨平台视频播放器
{
    public abstract class Tz20200440718_OperatingSystemVersion
    {
        private Tz20200440718_IVideoFile vf;

        public void SetVideoFile(Tz20200440718_IVideoFile vf)
        {
            throw new System.NotImplementedException();
        }
        public abstract void Play(string fileName);
    }
}