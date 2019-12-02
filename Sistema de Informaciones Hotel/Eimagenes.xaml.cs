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
    /// Lógica de interacción para Eimagenes.xaml
    /// </summary>
    public partial class Eimagenes : Window
    {
        public Eimagenes()
        {
            InitializeComponent();
        }

        private void lblInternacion_Click(object sender, RoutedEventArgs e)
        {
            Internacion view = new Internacion();
            view.Show();
        }

        private void lblresr_Click(object sender, RoutedEventArgs e)
        {
            Reserva view1 = new Reserva();
            view1.Show();
        }

        private void lbllabo_Click(object sender, RoutedEventArgs e)
        {
            Plaboratorio view2 = new Plaboratorio();
            view2.Show();
        }
    }
}
