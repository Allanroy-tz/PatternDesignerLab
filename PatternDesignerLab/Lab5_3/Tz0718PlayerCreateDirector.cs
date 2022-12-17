using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class Tz0718PlayerCreateDirector
    {
        public Tz0718Player Construct(Tz0718PlayerBuilder build)
        {
            build.BuildBody();
            build.BuildCostume();
            build.BuildWeapon(new Tz0718Pistol());
            return build.GetPlayer();
        }
    }
}
