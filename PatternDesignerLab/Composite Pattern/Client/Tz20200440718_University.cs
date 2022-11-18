using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    class Tz20200440718_University
    {
        private static Tz20200440718_University instance;
        public static Tz20200440718_University Instance 
        { get {
                if (instance == null) 
                    instance=new Tz20200440718_University();
                return instance; 
            } 
        }
        public Tz20200440718_Department 教务部 { get { return _教务部; } }

        private Tz20200440718_Department _教务部 = new Tz20200440718_Department("教务部");
        private Tz20200440718_University() { _教务部 = GetUniversity(); }

        static Tz20200440718_Department GetUniversity()
        {
            Tz20200440718_Unit 张三 = new Tz20200440718_Student("张三");
            Tz20200440718_Unit 李思 = new Tz20200440718_Student("李思");
            Tz20200440718_Unit 王舞 = new Tz20200440718_Student("王舞");
            Tz20200440718_Unit 刘俊 = new Tz20200440718_Student("刘俊");
            Tz20200440718_Unit 李晓 = new Tz20200440718_Student("李晓");
            Tz20200440718_Unit 赵慧 = new Tz20200440718_Student("赵慧");
            Tz20200440718_Unit 王芳 = new Tz20200440718_Student("王芳");
            Tz20200440718_Unit 阳阳 = new Tz20200440718_Student("阳阳");
            Tz20200440718_Unit 田甜 = new Tz20200440718_Student("田甜");

            Tz20200440718_Department 软件工程系 = new Tz20200440718_Department("软件工程系");
            Tz20200440718_Department 人工智能系 = new Tz20200440718_Department("人工智能系");
            Tz20200440718_Department 计算机学院 = new Tz20200440718_Department("计算机学院");
            Tz20200440718_Department 教务部 = new Tz20200440718_Department("教务部");
            Tz20200440718_Department 机械系 = new Tz20200440718_Department("机械系");
            Tz20200440718_Department 能动系 = new Tz20200440718_Department("能动系");
            Tz20200440718_Department 机器工程学院 = new Tz20200440718_Department("机器工程学院");

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
