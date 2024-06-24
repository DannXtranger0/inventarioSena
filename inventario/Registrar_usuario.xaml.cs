using inventario.Models;
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

namespace inventario
{
    /// <summary>
    /// Lógica de interacción para Registrar_usuario.xaml
    /// </summary>
    public partial class Registrar_usuario : Page
    {
        public Registrar_usuario()
        {
            InitializeComponent();
            getRoles();
        }

        public void getRoles()
        {
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                var roles_usuario = db.Roles.ToList();
                roles.ItemsSource = roles_usuario;
                roles.SelectedValuePath = "Id";
                roles.DisplayMemberPath = "NombreRol";
            }
        }

        public void crear_usuario()
        {
            using(SenaInventarioContext db = new SenaInventarioContext())
            {
                Usuario nuevo_usuario = new Usuario();
                
            }
        }
        

        private void btn_registro_Click(object sender, RoutedEventArgs e)
        {
            crear_usuario();
        } 
    }
}
