using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    public class Department : Unit
    {
        private List<Unit> unitList;
        public Department(string name) : base(name) { unitList = new List<Unit>(); }

        public void Add(Unit unit)
        {
            unitList.Add(unit);
            System.Console.WriteLine("成功添加“{0}”至“{1}”\n", unit.Name,this.Name);
        }
        public void Remove(Unit unit)
        {
            unitList.Remove(unit);
            System.Console.WriteLine("成功从“{0}”中移除“{1}\n”",this.Name, unit.Name);
        }
        public override void Receive(string msg)
        {
            //System.Console.WriteLine("{0}收到消息:{1}\n", Name, msg);
            foreach (Unit unit in unitList)
            {
                unit.Receive(msg);
            }
        }
        public Department FindDepartment(string name)
        {
            if (Name == name)
                return this;
            foreach (Unit unit in unitList)
            {
                if(unit.GetType()==Type.GetType("Composite_Pattern.Department"))
                {
                    Department dep = (Department)unit;
                    return dep.FindDepartment(name);
                }
            }
            return null;
        }

    }
}