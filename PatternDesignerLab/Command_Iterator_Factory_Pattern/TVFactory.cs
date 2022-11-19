using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public class TVFactory
    {
        public ITelevision GetTV(string tvType)
        {
            switch(tvType)
            {
                case "Brand01":return new Brand01Television();
                case "Brand02": return new Brand02Television();
                case "Brand03": return new Brand03Television();
            }
            return null;
        }
        public TVController GetTVController(string tvType)
        {
            switch (tvType)
            {
                case "Brand01":
                    {
                        ICommand Brand01Close, Brand01Open, Brand01Next, Brand01Previous;
                        Brand01Close = new CloseTVCommand();
                        Brand01Open = new OpenTVCommand();
                        Brand01Next = new NextChannelCommand();
                        Brand01Previous = new PreviousChannelCommand();
                        return new Brand01TVController(Brand01Close, Brand01Open, Brand01Next, Brand01Previous);
                    }
                case "Brand02":
                    {
                        ICommand Brand02Close, Brand02Open, Brand02Next, Brand02Previous;
                        Brand02Close = new CloseTVCommand();
                        Brand02Open = new OpenTVCommand();
                        Brand02Next = new NextChannelCommand();
                        Brand02Previous = new PreviousChannelCommand();
                        return new Brand02TVController(Brand02Close, Brand02Open, Brand02Next, Brand02Previous);
                    }
                case "Brand03":
                    {
                        ICommand Brand03Close, Brand03Open, Brand03Next, Brand03Previous;
                        Brand03Close = new CloseTVCommand();
                        Brand03Open = new OpenTVCommand();
                        Brand03Next = new NextChannelCommand();
                        Brand03Previous = new PreviousChannelCommand();
                        return new Brand03TVController(Brand03Close, Brand03Open, Brand03Next, Brand03Previous);
                    }
            }
            return null;
        }
    }
}