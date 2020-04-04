using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquario3D
{
    public class RainbowFish : OggettoMarinoAnimato
    {
        public RainbowFish(string addr, string name, int wdth, int hgt, double x, double y, bool dx) : base(addr, name, wdth, hgt, x, y, dx)
        {

        }

        public override void Movimento()
        {

            if (x >= 1024 || x <= 10)
            {
                goingRight = !goingRight;

            }

            if (goingRight)
            {
                x -= 8;
            }
            else
            {
                x += 8;
            }


        }

    }
}
