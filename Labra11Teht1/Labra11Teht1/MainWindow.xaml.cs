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

namespace Labra11Teht1
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

        //Stack<string> stackStrings = new Stack<string>();

        private void Milk_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)Milk.IsChecked)
            {
                
                List.Text = List.Text + "Milk\n";
            }
           
        }

        private void Butter_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)Butter.IsChecked)
            {
                List.Text = List.Text + "Butter\n";
            }
        }

        private void Beer_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)Beer.IsChecked)
            {
                List.Text = List.Text + "Beer\n";
            }
        }

        private void Chicken_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)Chicken.IsChecked)
            {
                List.Text = List.Text + "Chicken\n";
            }
        }

        private void Lemonade_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)Lemonade.IsChecked)
            {
                List.Text = List.Text + "Lemonade\n";
            }
        }

        private void List_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
