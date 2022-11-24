using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public class Tz202004407718_TVFactory
    {
        public Tz202004407718_ITelevision GetTV(string tvType)
        {
            switch(tvType)
            {
                case "Brand01":return new Tz202004407718_Brand01Television();
                case "Brand02": return new Tz202004407718_Brand02Television();
                case "Brand03": return new Tz202004407718_Brand03Television();
            }
            return null;
        }
        public Tz202004407718_TVController GetTVController(string tvType)
        {
            switch (tvType)
            {
                case "Brand01":
                    {
                        Tz202004407718_ICommand Brand01Close, Brand01Open, Brand01Next, Brand01Previous;
                        Brand01Close = new Tz202004407718_CloseTVCommand();
                        Brand01Open = new Tz202004407718_OpenTVCommand();
                        Brand01Next = new Tz202004407718_NextChannelCommand();
                        Brand01Previous = new Tz202004407718_PreviousChannelCommand();
                        return new Tz202004407718_Brand01TVController(Brand01Close, Brand01Open, Brand01Next, Brand01Previous);
                    }
                case "Brand02":
                    {
                        Tz202004407718_ICommand Brand02Close, Brand02Open, Brand02Next, Brand02Previous;
                        Brand02Close = new Tz202004407718_CloseTVCommand();
                        Brand02Open = new Tz202004407718_OpenTVCommand();
                        Brand02Next = new Tz202004407718_NextChannelCommand();
                        Brand02Previous = new Tz202004407718_PreviousChannelCommand();
                        return new Tz202004407718_Brand02TVController(Brand02Close, Brand02Open, Brand02Next, Brand02Previous);
                    }
                case "Brand03":
                    {
                        Tz202004407718_ICommand Brand03Close, Brand03Open, Brand03Next, Brand03Previous;
                        Brand03Close = new Tz202004407718_CloseTVCommand();
                        Brand03Open = new Tz202004407718_OpenTVCommand();
                        Brand03Next = new Tz202004407718_NextChannelCommand();
                        Brand03Previous = new Tz202004407718_PreviousChannelCommand();
                        return new Tz202004407718_Brand03TVController(Brand03Close, Brand03Open, Brand03Next, Brand03Previous);
                    }
            }
            return null;
        }
    }
}