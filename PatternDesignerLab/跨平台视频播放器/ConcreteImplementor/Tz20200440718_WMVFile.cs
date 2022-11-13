namespace 跨平台视频播放器
{
    public class Tz20200440718_WMVFile : Tz20200440718_IVideoFile
    {
        public void Decode(string osType, string fileName)
        {
            System.Console.WriteLine("操作系统：“{0}”，WMV类型：“{1}”", osType, fileName);
        }
    }
}