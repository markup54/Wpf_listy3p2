using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf_listy3p2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> slowa { get; set; } = new List<string>();
        public ObservableCollection<Produkt> produkty { get; set; } = new ObservableCollection<Produkt>()   ;

        public List<string> kategorie { get; set; } = new List<string> { "pieczywo", "nabiał", "owoce", "warzywa" };
        public MainWindow()
        {
            InitializeComponent();
            slowa.Add("informatyk");
            slowa.Add("algorytmy");
            slowa.Add("programista");
            produkty.Add(new Produkt("chleb", 4.56, true, "pieczywo"));
            produkty.Add(new Produkt("mleko", 2.99, true, "nabiał"));
            produkty.Add(new Produkt("jabłka", 3.99, false,  "owoce"));
            produkty.Add(new Produkt("gruszki", 8.99, true,  "owoce"));
            DataContext = this;
            datagridCombobox.ItemsSource = kategorie;
        }

        private void Button_Click_DodajProdukt(object sender, RoutedEventArgs e)
        {
            string nazwa = nazwaProduktuTextBox.Text;
            string kategoria = kategoriaComboBox.Text;
            bool czydostepny = czyDostepnyCheckBox.IsChecked == true ? true : false;
            double cena = 0;
            if(double.TryParse(cenaTextBox.Text, out cena))
            {

            }
            else
            {
                MessageBox.Show("cena musi być liczbą, zapisano 0");
            }
            produkty.Add(new Produkt(nazwa, cena, czydostepny, kategoria));
        }
    }
}
