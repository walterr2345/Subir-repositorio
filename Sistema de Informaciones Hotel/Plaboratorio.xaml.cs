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

namespace Sistema_de_Informaciones_Hotel
{
    /// <summary>
    /// Lógica de interacción para Plaboratorio.xaml
    /// </summary>
    public partial class Plaboratorio : Window
    {
        public Plaboratorio()
        {
            InitializeComponent();
        }

        private void lblInternacion_Click(object sender, RoutedEventArgs e)
        {
            Internacion viewinter = new Internacion();
            viewinter.Show();
        }

        private void lblresr_Click(object sender, RoutedEventArgs e)
        {
            Reserva viewinter = new Reserva();
            viewinter.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
