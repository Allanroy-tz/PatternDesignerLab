using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace The_Calculator
{
    public class Tz20200440718_theme01Factory : Tz20200440718_AbstractThemeFactory
    {
        public override Color GetColor()
        {
            return new Tz_20200440718_Color01().GetColor();
        }

        public override Font GetFont()
        {
            return new Tz_20200440718_Font01().GetFont();
        }
    }
}