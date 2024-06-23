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
        public PantallaAdmin()
        {
            InitializeComponent();
        }

        private void btn_inventario(object sender, RoutedEventArgs e)
        {
        Inventario_admin inventario_admin = new Inventario_admin();
            inventario_admin.Show();
        }
    }
}
