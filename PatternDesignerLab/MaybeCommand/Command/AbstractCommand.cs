using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public class AbstractCommand<T> where T:ISwitch
    {
        public Dictionary<int, T> objectDic=new Dictionary<int, T>();
        public virtual void Open(int num) { objectDic[num].Open(); }
        public virtual void Close(int num) { objectDic[num].Close(); }
        public virtual void OpenAll()
        {
            foreach (var item in objectDic)
            {
                item.Value.Open();
            }
        }
        public virtual void CloseAll()
        {
            foreach (var item in objectDic)
            {
                item.Value.Close();
            }  
        }
        public void AddObject(int num,T o)
        {
            objectDic.Add(num,o);
        }
        public void RemoveObject(int num)
        {
            objectDic.Remove(num);
        }
    }
}