using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class Tz0718SniperRifle : Tz0718Weapon
    {
        string weaponName = "狙击枪";
        public void DisPlay()
        {
            System.Console.WriteLine("狙击枪"); 
        }

        public string fire()
        {
            return ("狙击枪射击");
        }

        public string GetWeaponName()
        {
            return weaponName;
        }

        public void Use()
        {
            System.Console.WriteLine("使用狙击枪");
        }
    }
}
