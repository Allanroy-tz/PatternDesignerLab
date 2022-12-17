using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class Tz0718Pistol : Tz0718Weapon
    {
        string weaponName = "手枪";
        public void DisPlay()
        {
            System.Console.WriteLine("手枪");
        }

        public string fire()
        {
            return "手枪子弹";
        }

        public string GetWeaponName()
        {
            return weaponName;
        }

        public void Use()
        {
            System.Console.WriteLine("使用了手枪");
        }
    }
}
