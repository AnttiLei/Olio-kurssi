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

namespace Labra10teht1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        int cars = 0;
        int trucks = 0;
        private void Trucks_Click(object sender, RoutedEventArgs e)
        {
            trucks++;
            InfoTrucks.Text = trucks.ToString();
        }

        private void Cars_Click(object sender, RoutedEventArgs e)
        {
            cars++;
            InfoCars.Text = cars.ToString();
        }
    }
}
