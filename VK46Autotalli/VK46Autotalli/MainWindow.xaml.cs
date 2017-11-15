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
using JAMK.IT;

namespace VK46Autotalli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autot; //muuttuja on käytettävissä kaikissa luokas metodeissa ja tapahtumankäsittelijöissä
        private const string polku = @"d:\\kuvat\\";
        public MainWindow()
        {
            //Tänne koodi joka suoritetaan ikkunan avauksen luonnissa
            InitializeComponent();
            //Pyydetään BL-kerrokselta autot, ja näytetään ne käyttäjälle
            autot = Autotalli.HaeAutot();
            NaytaKuva("autotalli.png");
            //Asetetaan comboboxiin kaikki eri automerkit
            //Vaihtoehto 1: Käsin koodaamalla
            List<string> merkit = new List<string>();
            merkit.Add("Audi");
            merkit.Add("Saab");
            merkit.Add("Volvo");
            merkit.Add("Renault");
            //Vaihtoehto 2: Parempi, kysytään LINQ:lla datasta eri automerkit
            var result = autot.Select(m => m.Merkki).Distinct();
            cmbAutot.ItemsSource = result;
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            dgAutot.ItemsSource = autot;

        }
        private void NaytaKuva(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    url = "puuttuu.png";
                }
                //Lisätään kuvatiedostojen vakiopolku
                url = polku + url;
                //Kuvan näyttö
                BitmapImage pic = new BitmapImage();
                pic.BeginInit();
                pic.UriSource = new Uri(url);
                pic.EndInit();
                imgAuto.Stretch = Stretch.Fill;
                imgAuto.Source = pic;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //huom, olemme itse populoineet DataGridin Auto-olioilla, joten kukin DataGridin jäsen/alkio on itseasiassa Auto-olio
            object obj = dgAutot.SelectedItem;
            if (obj != null)
            {
                Auto valittu = (Auto)obj;
                NaytaKuva(valittu.URL);
            }
        }

        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            //Näkyviin pelkästään Audi-merkkiset autot
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }

        private void cmbAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Suodatetaan DataGridiin näkyviin vain valittu automerkki
            string merkki = cmbAutot.SelectedValue.ToString();
            var result = autot.Where(m => m.Merkki.Contains(merkki));
            dgAutot.ItemsSource = result;
            
        }
    }
}
