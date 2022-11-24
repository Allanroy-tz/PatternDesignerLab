using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public class Tz20200440718_CommandGroup : Tz20200440718_AbstractCommandGroup
    {
        Dictionary<int, Tz20200440718_AbstractCommandGroup> switchDic = new Dictionary<int, Tz20200440718_AbstractCommandGroup>();
        public void Add(int i, Tz20200440718_AbstractCommandGroup controller)
        {
            switchDic.Add(i, controller);
        }
        public void Remove(int i)
        {
            switchDic.Remove(i);
        }
        public void CloseAt(int i)
        {
            switchDic[i].Close();
        }
        public void OpenAt(int i)
        {
            switchDic[i].Open();
        }
        public override void Open()
        {
            foreach (var item in switchDic)
            {
                item.Value.Open();
            }
        }
        public override void Close()
        {
            foreach (var item in switchDic)
            {
                item.Value.Close();
            }
        }
    }
}