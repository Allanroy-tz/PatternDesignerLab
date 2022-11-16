namespace Command_Pattern
{
    public class Light : ISwitch
    {
        int num;
        public Light(int num) { this.num = num; }
        public void Open()
        {
            System.Console.WriteLine("灯编号:“{0}” 打开！", num);
        }
        public void Close()
        {
            System.Console.WriteLine("灯编号:“{0}” 关闭！", num);
        }
    }
}