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
using System.Xml;

namespace NET_PR2_2_z3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

	ListBox lista;
        public MainWindow()
        {
            InitializeComponent();
            lista = (ListBox)FindName("Kategorie");
        }

        private void WidokWybranejKategorii(object sender, RoutedEventArgs e)
        {
            XmlElement wybrana = (XmlElement)lista.SelectedItem;
            new Window2(wybrana).Show();
        }

        private void Kategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

}

