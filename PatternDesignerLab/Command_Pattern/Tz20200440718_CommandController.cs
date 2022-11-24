using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public class Tz20200440718_CommandController : Tz20200440718_AbstractCommandGroup
    {
        Tz20200440718_ICommnad close, open;
        public Tz20200440718_CommandController(Tz20200440718_ICommnad close,Tz20200440718_ICommnad open)
        {
            this.close = close;
            this.open = open;
        }

        public override void Close()
        {
            close.Execute();
        }

        public override void Open()
        {
            open.Execute();
        }
    }
}