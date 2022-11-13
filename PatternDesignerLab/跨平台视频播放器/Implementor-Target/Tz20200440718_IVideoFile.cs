using System;
using System.Collections.Generic;
using System.Text;

namespace 跨平台视频播放器
{
    public interface Tz20200440718_IVideoFile
    {
        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="osType">操作系统类型</param>
        /// <param name="fileName">解码类型</param>
        void Decode(string osType, string fileName);
    }
}