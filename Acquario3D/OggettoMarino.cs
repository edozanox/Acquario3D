using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Acquario3D
{
    public abstract class OggettoMarino
    {
        public string path { get; private set; }
        public string nome { get; private set; }

        public int altezza { get; private set; }
        public int larghezza { get; private set; }
        public double x { get; protected set; }
        public double y { get; protected set; }
        public bool goingRight { get; set; }
        public Image Image { get; private set; }
        

       
        public OggettoMarino(string addr, string name, int wdth, int hgt, double X, double Y, bool dx)
        {
            path = addr;
            nome = name;
            altezza = hgt;
            larghezza = wdth;
            goingRight = dx;
            x = X;
            y = Y;

            Image fish = new Image();
            Uri fishURI = new Uri(path, UriKind.Relative);
            fish.Source = new BitmapImage(fishURI);
            fish.Width = larghezza;
            fish.Height = altezza;            
            Image = fish;
            
        }

        public OggettoMarino(string addr, string name, int wdth, int hgt, double X, double Y)
        {
            path = addr;
            nome = name;
            altezza = hgt;
            larghezza = wdth;            
            x = X;
            y = Y;

            Image fish = new Image();
            Uri fishURI = new Uri(path, UriKind.Relative);
            fish.Source = new BitmapImage(fishURI);
            fish.Width = larghezza;
            fish.Height = altezza;
            Image = fish;

        }

        public virtual void Rendering()
        {

            /*
            img.RenderTransformOrigin = new Point(0.5, 0.5);
            ScaleTransform flipTrans = new ScaleTransform();
            flipTrans.ScaleX = -1;
            img.RenderTransform = flipTrans;
            */

            TransformGroup myTransformGroup = new TransformGroup();
            TranslateTransform translateTransform = new TranslateTransform(this.x, this.y);
            ScaleTransform scaleTrasform;

            if (goingRight)
            {
                scaleTrasform = new ScaleTransform(1, 1);
            }
            else
            {

                scaleTrasform = new ScaleTransform(-1, 1);
            }

            myTransformGroup.Children.Add(scaleTrasform);
            myTransformGroup.Children.Add(translateTransform);
            this.Image.RenderTransform = myTransformGroup;

        }

    }

}
