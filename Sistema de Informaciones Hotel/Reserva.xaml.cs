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
    /// Lógica de interacción para Reserva.xaml
    /// </summary>
    public partial class Reserva : Window
    {
        public Reserva()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

           Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("LLene los datos", "Registro");
        }

        private void lblInternacion_Click(object sender, RoutedEventArgs e)
        {
            Internacion viewinter = new Internacion();
            viewinter.Show();
        }
    }
}
