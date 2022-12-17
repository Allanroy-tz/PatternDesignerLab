using System;

namespace Lab5_3
{
    public abstract class Tz0718PlayerBuilder
    {
        public abstract void BuildBody();

        public abstract void BuildCostume();

        public abstract void BuildWeapon(Tz0718Weapon weapon);

        public abstract Tz0718Player GetPlayer();
    }
}