using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class Tz0718FemaleSoldier : Tz0718PlayerBuilder
    {
        Tz0718Player player;
        public Tz0718FemaleSoldier(string name) { player = new Tz0718Player(name); }
        public override void BuildBody()
        {
            player.SetBody("女武士造型");
        }
        public override void BuildCostume()
        {
            player.SetBody("女武神服装");
        }

        public override void BuildWeapon(Tz0718Weapon weapon)
        {
            player.SetWeapon(weapon);
        }

        public override Tz0718Player GetPlayer()
        {
            return player;
        }
    }
}
