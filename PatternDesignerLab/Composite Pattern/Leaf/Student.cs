using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    public class Student : Unit
    {
        public Student(string name) : base(name) { }
        public override void Receive(string msg)
        {
            System.Console.WriteLine("{0}收到消息:{1}\n", Name, msg);
        }
    }
}