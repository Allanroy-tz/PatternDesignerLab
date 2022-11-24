
namespace Command_Pattern
{
    public class Tz20200440718_AirFan : Tz20200440718_ISwitch
    {
        int num;
        public Tz20200440718_AirFan(int num) { this.num = num; }
        public void Close()
        {
            System.Console.WriteLine("风扇编号：“{0}” 关闭！", num);
        }

        public void Open()
        {
            System.Console.WriteLine("风扇编号：“{0}” 打开！", num);
        }
    }
}