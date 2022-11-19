using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public class Brand02Iterator : ITVIterator
    {
        Brand02Television tv;
        int index = 1;
        public Brand02Iterator(Brand02Television tv) { this.tv = tv; index = tv.GetCurrentChannelIndex(); }
        public System.Object CurrentChannel()
        {
            System.Console.WriteLine("当前频道为{0}", tv.channelList[index - 1]);
            return tv.channelList[index - 1];
        }

        public bool IsFirst()
        {
            return index < 1;
        }

        public bool IsLast()
        {
            return index > tv.channelList.Count;
        }
        public void Next()
        {
            System.Console.WriteLine("切换下一频道成功");
            index++;
            if (IsLast())
            {
                index = 1;
            }
            tv.SetChannelIndex(index);
        }

        public void Previous()
        {
            System.Console.WriteLine("切换前一频道成功");
            index--;
            if (IsFirst())
            {
                index = tv.channelList.Count;
            }
            tv.SetChannelIndex(index);
        }

        public void SetChannel(int i)
        {
            if (i > 0 && i <= tv.channelList.Count)
                index = i;
            else
                System.Console.WriteLine("没有这个频道");
        }
    }
}