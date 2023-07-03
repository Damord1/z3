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
using System.Windows.Shapes;
using System.Xml;

namespace NET_PR2_2_z3
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        ListBox lista;
        public Window2(XmlElement kategoria)
        {
            DataContext = kategoria;
            InitializeComponent();
            lista = (ListBox)FindName("Podkategorie");
        }
        private void WidokWięcej(object sender, RoutedEventArgs e)
        {

            XmlElement wybrana = (XmlElement)lista.SelectedItem;
            new Window1(wybrana)
                .Show();

        }
    }
}
