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
    /// Lógica de interacción para Internacion.xaml
    /// </summary>
    public partial class Internacion : Window
    {
        public Internacion()
        {
            InitializeComponent();
        }

        private void Interna_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lblresr_Click(object sender, RoutedEventArgs e)
        {
            Reserva viewres = new Reserva();
            //viewres.ShowDialog();
            //Close();
            System.Windows.Application.Current.Shutdown();
        }

        private void lbllabo_Click(object sender, RoutedEventArgs e)
        {
            Plaboratorio viewinter = new Plaboratorio();
            viewinter.Show();
        }
    }
}
