using System;
using System.Collections.Generic;
using System.Text;

namespace 跨平台视频播放器
{
    public abstract class Tz20200440718_OperatingSystemVersion
    {
        protected Tz20200440718_IVideoFile vf;

        public void SetVideoFile(Tz20200440718_IVideoFile vf)
        {
            this.vf = vf;
        }
        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="fileName">解码内容</param>
        public abstract void Play(string fileName);
    }
}