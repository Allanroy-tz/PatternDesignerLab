using System;

namespace State_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Player 张三 = new Player("张三");
            
            张三.Win();
            张三.Win();
            张三.DoubleScore();
            张三.Lose();
            张三.Win();
            张三.DoubleScore();
            张三.PeekCards();
            张三.ChangeCards();
        }
    }
}
