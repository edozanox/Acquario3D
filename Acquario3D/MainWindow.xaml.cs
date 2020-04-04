using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Timers;
using System.Diagnostics;

namespace Acquario3D
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer dt;
        public List<OggettoMarinoAnimato> DatabaseOggettiMarini { get; } = new List<OggettoMarinoAnimato>();
        public List<OggettoMarinoStatico> DatabaseElementiStatici { get; } = new List<OggettoMarinoStatico>();
                
        public MainWindow()
        {
            InitializeComponent();
            InitializeElement();
            dt = new DispatcherTimer(TimeSpan.FromMilliseconds(150), DispatcherPriority.Render, MovingElements, Dispatcher);
            dt.Start();

        }

        private void MovingElements(object sender, EventArgs e)
        {
            foreach (OggettoMarinoAnimato fish in DatabaseOggettiMarini)
            {
                fish.Movimento();
                fish.Image.RenderTransform = new TranslateTransform(fish.x, fish.y);

                foreach (OggettoMarinoAnimato pesce in DatabaseOggettiMarini)
                {
                    fish.Rendering();
                }
                
            }

            foreach (OggettoMarinoStatico elem in DatabaseElementiStatici)
            {
                elem.Image.RenderTransform = new TranslateTransform(elem.x, elem.y);
                elem.Rendering();
             
            }
        }


        private void InitializeElement()
        {
            OggettoMarinoAnimato PesceRosso = new Goldfish("Images\\Goldfish.png", "PesceRosso", 220, 200, 10 , 20, false);
            OggettoMarinoAnimato PesceScalare = new Scalare("Images\\Scalare.png", "PesceScalare", 200, 150, 20, 150, false);
            OggettoMarinoAnimato PesceArcobaleno = new Melanotide("Images\\RainbowFish.png", "PesceRainbow1", 250, 200, 30, 250, true);
            OggettoMarinoAnimato PesceRainbow = new RainbowFish("Images\\RainbowFishTwo.png", "PesceRainbow2", 250, 150, 70, 400, false);
            DatabaseOggettiMarini.Add(PesceRosso);
            DatabaseOggettiMarini.Add(PesceScalare);
            DatabaseOggettiMarini.Add(PesceArcobaleno);
            DatabaseOggettiMarini.Add(PesceRainbow);

            OggettoMarinoStatico Conchiglie = new OggettoMarinoStatico("Images\\Conchiglie.png", "Conchiglia_StellaMarina", 200, 250, 800, 500);
            OggettoMarinoStatico Nautilus = new OggettoMarinoStatico("Images\\Nautilus.png", "Nautilus", 150, 100, 900, 550);
            OggettoMarinoStatico ConcNautilus = new OggettoMarinoStatico("Images\\ConchigliaTipoNautilus.png", "ConcNaut", 100, 100, 400, 550);
            DatabaseElementiStatici.Add(Conchiglie);
            DatabaseElementiStatici.Add(Nautilus);
            DatabaseElementiStatici.Add(ConcNautilus);

            foreach (OggettoMarinoAnimato fish in DatabaseOggettiMarini)
            {
                Fondale.Children.Add(fish.Image);
            }
            foreach (OggettoMarinoStatico elem in DatabaseElementiStatici)
            {
                Fondale.Children.Add(elem.Image);
            }
            
        }
    }
}