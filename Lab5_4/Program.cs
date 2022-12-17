using System;

namespace Lab5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("==========指纹识别取款操作=========="); 
            Tz0718BankTerminal bankTerminal = new Tz0718Withdraw(); 
            bankTerminal.SetFactory(new Tz0718FingerPrintFactory()); 
            bankTerminal.Process();
            Console.WriteLine("==========密码识别转账操作=========="); 
            bankTerminal = new Tz0718Transfer();
            bankTerminal.SetFactory(new Tz0718PasswordFactory()); 
            bankTerminal.Process();
            Console.WriteLine("==========面部识别转账操作========== "); 
            bankTerminal.SetFactory(new Tz0718FaceRecognitionFactory()); bankTerminal.Process();

        }
    }
}
