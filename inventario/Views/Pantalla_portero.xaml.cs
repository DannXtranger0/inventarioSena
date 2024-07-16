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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace inventario.Views
{
    /// <summary>
    /// Lógica de interacción para Pantalla_portero.xaml
    /// </summary>
    public partial class Pantalla_portero : Window
    {
        private int id_usuario;
        public Pantalla_portero(int userID)
        {
            //obterner id del usuario que inicia sesion
            this.id_usuario = userID;
             

            InitializeComponent();
            frame_principal.Navigate(new Registro_prestamo(id_usuario));
        }

        private void btn_hidtorial_Click(object sender, RoutedEventArgs e)
        {
            frame_principal.Navigate(new Registro_prestamo(id_usuario));
        }

        private void btn_devolver_Click(object sender, RoutedEventArgs e)
        {
            frame_principal.Navigate(new Historial_prestamo_portero());

        }
    }
}
