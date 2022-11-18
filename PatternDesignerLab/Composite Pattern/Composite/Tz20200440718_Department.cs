using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    public class Tz20200440718_Department : Tz20200440718_Unit
    {
        private List<Tz20200440718_Unit> unitList;
        public Tz20200440718_Department(string name) : base(name) { unitList = new List<Tz20200440718_Unit>(); }

        public void Add(Tz20200440718_Unit unit)
        {
            unitList.Add(unit);
            System.Console.WriteLine("成功添加“{0}”至“{1}”\n", unit.Name,this.Name);
        }
        public void Remove(Tz20200440718_Unit unit)
        {
            unitList.Remove(unit);
            System.Console.WriteLine("成功从“{0}”中移除“{1}\n”",this.Name, unit.Name);
        }
        public override void Receive(string msg)
        {
            //System.Console.WriteLine("{0}收到消息:{1}\n", Name, msg);
            foreach (Tz20200440718_Unit unit in unitList)
            {
                unit.Receive(msg);
            }
        }
        public Tz20200440718_Department FindDepartment(string name)
        {
            if (Name == name)
                return this;
            foreach (Tz20200440718_Unit unit in unitList)
            {
                if(unit.GetType()==Type.GetType("Composite_Pattern.Department"))
                {
                    Tz20200440718_Department dep = (Tz20200440718_Department)unit;
                    return dep.FindDepartment(name);
                }
            }
            return null;
        }

    }
}