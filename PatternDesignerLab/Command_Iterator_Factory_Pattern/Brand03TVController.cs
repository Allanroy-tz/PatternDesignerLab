using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public class Brand03TVController : TVController
    {
        ICommand close, open, next, previous;

        public Brand03TVController(ICommand close, ICommand open, ICommand next, ICommand previous)
        {
            this.close = close;
            this.open = open;
            this.next = next;
            this.previous = previous;
        }
        public override void SetTV(ITelevision tv)
        {
            ITVIterator iterator = tv.CreateIterator();
            close.Set(tv);
            open.Set(tv);
            next.Set(iterator);
            previous.Set(iterator);
            System.Console.WriteLine("遥控器连接成功！");
        }
        public override void CloseTV()
        {
            close.Execute();
        }

        public override void NextChannel()
        {
            next.Execute();
        }

        public override void OpenTV()
        {
            open.Execute();
        }

        public override void PreviousChannel()
        {
            previous.Execute();
        }
    }
}