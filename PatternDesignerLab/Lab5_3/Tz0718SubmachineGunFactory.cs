using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class Tz0718SubmachineGunFactory : Tz0718WeaponFactory
    {
        public Tz0718Weapon CreateWeapon()
        {
            return new Tz0718SubmachineGun();
        }
    }
}
