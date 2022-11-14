using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    class University
    {
        private static University instance;
        public static University Instance 
        { get {
                if (instance == null) 
                    instance=new University();
                return instance; 
            } 
        }
        public Department 教务部 { get { return _教务部; } }

        private Department _教务部 = new Department("教务部");
        private University() { _教务部 = GetUniversity(); }

        static Department GetUniversity()
        {
            Unit 张三 = new Student("张三");
            Unit 李思 = new Student("李思");
            Unit 王舞 = new Student("王舞");
            Unit 刘俊 = new Student("刘俊");
            Unit 李晓 = new Student("李晓");
            Unit 赵慧 = new Student("赵慧");
            Unit 王芳 = new Student("王芳");
            Unit 阳阳 = new Student("阳阳");
            Unit 田甜 = new Student("田甜");

            Department 软件工程系 = new Department("软件工程系");
            Department 人工智能系 = new Department("人工智能系");
            Department 计算机学院 = new Department("计算机学院");
            Department 教务部 = new Department("教务部");
            Department 机械系 = new Department("机械系");
            Department 能动系 = new Department("能动系");
            Department 机器工程学院 = new Department("机器工程学院");

            软件工程系.Add(张三);
            软件工程系.Add(李思);
            软件工程系.Add(王舞);
            人工智能系.Add(刘俊);
            人工智能系.Add(李晓);
            计算机学院.Add(软件工程系);
            计算机学院.Add(人工智能系);

            机械系.Add(赵慧);
            机械系.Add(王芳);
            能动系.Add(阳阳);
            能动系.Add(田甜);
            机器工程学院.Add(机械系);
            机器工程学院.Add(能动系);

            教务部.Add(计算机学院);
            教务部.Add(机器工程学院);

            return 教务部;
        }
    }
}
