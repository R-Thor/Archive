using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGravityModel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class StellarObject
        {
            public double Mass { get; set; }
            public Ellipse RepresentedAs { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            StellarObject Earth = new StellarObject() { Mass = 100, RepresentedAs = EarthStelarObject };
            StellarObject Moon = new StellarObject() { Mass = 10, RepresentedAs = MoonStelarObject };
            StartGravity(new StellarObject[] { Earth,Moon});
        }
        
        private void StartGravity(StellarObject[] stellarObject)
        {
            GetForce(stellarObject);
        }

        private void GetForce(StellarObject[] stellarObject)
        {
            System.Diagnostics.Debug.WriteLine(gravity(100, 10, 100));
        }
        private double gravity(double m1, double m2, double r)
        {
            double G = 6.674d * Math.Pow(10,-11);

            double f = (G * m1 * m2) / Math.Pow(r,2);

            return f;
        }
    }
}
