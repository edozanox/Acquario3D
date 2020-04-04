using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquario3D
{
    public class Goldfish : OggettoMarinoAnimato
    {
        public Goldfish(string addr, string name, int wdth, int hgt, double x, double y, bool dx) : base(addr, name, wdth, hgt, x, y, dx)
        {


        }

        public override void Movimento()
        {
            
            if (x >= 1030 || x <= -5)
            {
                goingRight = !goingRight;

            }
            
            if(goingRight)
            {
                x += 10;
            }
            else
            {
                x -= 10;
            }
              

            
        }


    }
}
