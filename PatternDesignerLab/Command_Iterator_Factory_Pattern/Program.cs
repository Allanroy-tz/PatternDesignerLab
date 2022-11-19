using System;

namespace Command_Iterator_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TVFactory tVFactory = new TVFactory();
            ITelevision tv01 = tVFactory.GetTV("Brand01");
            TVController tv01Controller = tVFactory.GetTVController("Brand01");
            tv01Controller.SetTV(tv01);
            tv01Controller.NextChannel();
            tv01Controller.NextChannel();
            tv01Controller.NextChannel();
            TVController tv01Controller01 = tVFactory.GetTVController("Brand01");
            tv01Controller01.SetTV(tv01);
            tv01Controller01.NextChannel();

        }
    }
}
