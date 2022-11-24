
namespace Command_Pattern
{
    public class AirFan : ISwitch
    {
        int num;
        public AirFan(int num) { this.num = num; }
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