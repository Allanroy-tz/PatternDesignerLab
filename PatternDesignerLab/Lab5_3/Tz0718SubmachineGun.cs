using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class Tz0718SubmachineGun : Tz0718Weapon
    {
        string weaponName = "冲锋枪";
        public void DisPlay()
        {
            System.Console.WriteLine("这是一把冲锋枪");
        }

        public string fire()
        {
            return "冲锋枪射击";
        }

        public string GetWeaponName()
        {
            return weaponName;
        }

        public void Use()
        {
            Console.WriteLine("使用了冲锋枪");
        }
    }
}
