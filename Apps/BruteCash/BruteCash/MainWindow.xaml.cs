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

namespace BruteCash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Model.DataAdapterDataSet2XML Test2;
        public MainWindow()
        {
            InitializeComponent();
                    //Model.DataAdapterLinq2XML Test = new Model.DataAdapterLinq2XML();

            Test2 = new Model.DataAdapterDataSet2XML();

            this.dataGrid1.ItemsSource = Test2.testDataSet.Tables[BruteCash.Model.MetaData.Models.ModelTransaction.ModelName].DefaultView;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
