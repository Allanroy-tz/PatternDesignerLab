
namespace Command_Pattern
{
    public class AirConditioner : ISwitch
    {
        int num;
        public AirConditioner(int num) { this.num = num; }
        public void Close()
        {
            System.Console.WriteLine("空调编号：“{0}”关闭！", num);
        }

        public void Open()
        {
            System.Console.WriteLine("空调编号：“{0}”打开！", num);
        }
    }
}