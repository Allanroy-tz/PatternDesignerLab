namespace 跨平台视频播放器
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Tz20200440718_OperatingSystemVersion Windows = new Tz20200440718_WindowsVersion();
            Tz20200440718_OperatingSystemVersion Linux = new Tz20200440718_LinuxVersion();
            Tz20200440718_OperatingSystemVersion HarmonyOs = new Tz20200440718_HarmonyOsVersion();

            Tz20200440718_IVideoFile AVI = new Tz20200440718_AVIFile();
            Tz20200440718_IVideoFile MP4 = new Tz20200440718_MP4File();
            Tz20200440718_IVideoFile WMV = new Tz20200440718_WMVFile();
            Tz20200440718_IVideoFile MPEG = new Tz20200440718_MPEGAdapter();
            System.Console.WriteLine("-------------测试Windows平台-------------");
            string video = "夏日重现";
            Windows.SetVideoFile(AVI);
            Windows.Play(video);
            Windows.SetVideoFile(WMV);
            Windows.Play(video);
            Windows.SetVideoFile(MPEG);
            Windows.Play(video);
            Windows.SetVideoFile(MP4);
            Windows.Play(video);
            System.Console.WriteLine("-------------测试Linux平台-------------");
            Linux.SetVideoFile(AVI);
            Linux.Play(video);
            Linux.SetVideoFile(WMV);
            Linux.Play(video);
            Linux.SetVideoFile(MPEG);
            Linux.Play(video);
            Linux.SetVideoFile(MP4);
            Linux.Play(video);
            System.Console.WriteLine("-------------测试HarmonyOs平台-------------");
            HarmonyOs.SetVideoFile(AVI);
            HarmonyOs.Play(video);
            HarmonyOs.SetVideoFile(WMV);
            HarmonyOs.Play(video);
            HarmonyOs.SetVideoFile(MPEG);
            HarmonyOs.Play(video);
            HarmonyOs.SetVideoFile(MP4);
            HarmonyOs.Play(video);

        }
    }
}
