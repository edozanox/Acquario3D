using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Acquario3D
{
    public abstract class OggettoMarinoAnimato : OggettoMarino
    {
        /// <summary>
        /// Acquario3D - Inserimento elemento animato
        /// </summary>
        /// <param name="addr">Inserire l'URI relativo dell'immagine</param>
        /// <param name="name">Inserire un nome identificativo dell'elemento</param>
        /// <param name="wdth">Larghezza in px</param>
        /// <param name="hgt">Altezza in px</param>

        public OggettoMarinoAnimato(string addr, string name, int wdth, int hgt, double x, double y, bool dx) : base(addr, name, wdth, hgt, x, y, dx)
        {
            

        }

        public abstract void Movimento();
       

    }
}

