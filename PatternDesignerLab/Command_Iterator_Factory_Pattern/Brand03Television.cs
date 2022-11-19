using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public class Brand03Television : ITelevision
    {
        public List<string> channelList = new List<string>() { "CCTV-1", "CCTV-2", "CCTV-3", "CCTV-4", "CCTV-5", "CCTV-6" };
        int currentChannelIndex = 1;
        public int GetCurrentChannelIndex() { return currentChannelIndex; }
        public void SetChannelIndex(int i)
        {
            currentChannelIndex = i;
        }
        public void Close()
        {
            System.Console.WriteLine("Brand01Television关闭！");
        }

        public ITVIterator CreateIterator()
        {
            return new Brand03Iterator(this);
        }

        public void Open()
        {
            System.Console.WriteLine("Brand01Television打开！");
        }
    }
}