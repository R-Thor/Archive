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
using System.Diagnostics;

namespace ExploreCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //List<int> prime = GetPrimes().ToList<int>();
            //List<int> primeNumbersList = prime.Distinct().ToList<int>();
            double squareRoot = GetSquareOf(3);
        }

        private double GetSquareOf(long p)
        {
            double returnValue=0;
            long x = 0;
            long log = 1;
            for (; p != (x * x); p *= (log * log),log*=10,x++)
            {

            }

            //for (int x = 0; x < p; x++)
            //{
            //    if ((x * x) == p)
            //    {
            //        returnValue = (double)x;
            //        break;
            //    }
            //    if ((x * x) < p && ((x + 1) * (x + 1)) > p)
            //    {
            //        p *= 100;
            //        for (int y = x*10; y < (x + 1)*10; y ++) 
            //        {
            //            if ((y * y) < p && ((y + 10) * (y + 10)) > p*10*10)
            //            {

            //            }
            //        }
            //        //sqrroot between x and (x + 1)
            //    }
            //}
            return returnValue;
        }

        public IEnumerable<int> GetPrimes()
        {
            DateTime dt = DateTime.Now;
            int LoopNum = 4;
            while (DateTime.Now < dt.AddSeconds(60))
            {
                for (int x = 2; x < LoopNum; x++)
                {
                    //Debug.WriteLine(x.ToString());
                    if
                    (
                        LoopNum % x == 0
                    )
                    {
                        
                        //Debug.WriteLine(LoopNum.ToString());
                        break;
                    }
                    Debug.WriteLine(LoopNum.ToString());
                    yield return LoopNum;
                }
                LoopNum++;
                yield return LoopNum;
            }
        }
    }
}
