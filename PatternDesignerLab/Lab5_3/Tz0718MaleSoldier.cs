using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class Tz0718MaleSoldier : Tz0718PlayerBuilder
    {
        private Tz0718Player player;
        public Tz0718MaleSoldier(string name) { player = new Tz0718Player(name); }
        public override void BuildBody()
        {
            player.SetBody("男武士造型");
        }
        public override void BuildCostume()
        {
            player.SetCostume("流浪武士装扮");
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
