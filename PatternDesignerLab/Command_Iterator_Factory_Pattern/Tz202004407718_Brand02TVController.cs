using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public class Tz202004407718_Brand02TVController : Tz202004407718_TVController
    {
        Tz202004407718_ICommand close, open, next, previous;

        public Tz202004407718_Brand02TVController(Tz202004407718_ICommand close, Tz202004407718_ICommand open, Tz202004407718_ICommand next, Tz202004407718_ICommand previous)
        {
            this.close = close;
            this.open = open;
            this.next = next;
            this.previous = previous;
        }
        public override void SetTV(Tz202004407718_ITelevision tv)
        {
            Tz202004407718_ITVIterator iterator = tv.CreateIterator();
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