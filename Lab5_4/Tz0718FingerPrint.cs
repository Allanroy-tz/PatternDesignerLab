using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_4
{
    public class Tz0718FingerPrint : Tz0718FingerPrintReader, Tz0718IAuthentication
    {
        public void Authorize()
        {
            System.Console.WriteLine("指纹识别验证身份");
            Process();
        }
    }
}
