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

namespace inventario.Views
{
    /// <summary>
    /// Interaction logic for PantallaAdmin.xaml
    /// </summary>
    public partial class PantallaAdmin : Window
    {
        private int userId;
        public PantallaAdmin(int id_usuario)
        {
            //obterner id del usuario que inicia sesion
            this.userId = id_usuario;
            InitializeComponent();
            
            frame_principal.Navigate(new Historial_prestamos());
        }

        private void btn_inventario(object sender, RoutedEventArgs e)
        {
        Inventario_admin inventario_admin = new Inventario_admin();
            inventario_admin.Show();
        }

       

        private void btn_historial_Click(object sender, RoutedEventArgs e)
        {

            frame_principal.Navigate(new Historial_prestamos());
        }

        private void btn_registro_pe_Click(object sender, RoutedEventArgs e)
        {
            frame_principal.Navigate(new Registro_personas());

        }
    }
}
