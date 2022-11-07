using System;

namespace The_Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!!!");
            Tz20200440718_Assembler assembler=new Tz20200440718_Assembler();
            Tz20200440718_ComputerAbstractBuilder builder;
            Tz20200440718_Computer computer;
            builder = new Tz20200440718_ComputerBuilder01();
            assembler.SetBuilder(builder);
            computer=assembler.construct();
            computer.show();
            System.Console.WriteLine("-----------------------------");
            builder = new Tz20200440718_ComputerBuilder02();
            assembler.SetBuilder(builder);
            computer = assembler.construct();
            computer.show();
            System.Console.WriteLine("-----------------------------");
            builder = new Tz20200440718_ComputerBuilder03(); 
            assembler.SetBuilder(builder);
            computer = assembler.construct();
            computer.show();
            System.Console.WriteLine("-----------------------------");
        }
    }
}
