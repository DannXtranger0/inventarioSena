using inventario.Models;
using inventario.Views;
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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }



        private void ver_contraseña_Unchecked(object sender, RoutedEventArgs e)
        {
            contrasenia_show.Visibility = Visibility.Visible;
            contrasenia_txt.Visibility = Visibility.Collapsed;
            contrasenia_show.Password = contrasenia_txt.Text; // Sincronizar el valor
        }

        private void ver_contraseña_Checked(object sender, RoutedEventArgs e)
        {
            contrasenia_show.Visibility = Visibility.Collapsed;
            contrasenia_txt.Visibility = Visibility.Visible;
            contrasenia_txt.Text = contrasenia_show.Password; // Sincronizar el valor
        }

        private void btnIniciarSesion_Click_1(object sender, RoutedEventArgs e)
        {
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                var usuario = txtUsername.Text;
                var contrasenia = contrasenia_show.Password;
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Este campo es obligatorio");
                }
                else if (string.IsNullOrEmpty(contrasenia))
                {
                    MessageBox.Show("Este campo es obligatorio");
                }
                else
                {
                    Usuario usua = db.Usuarios.FirstOrDefault(us => us.NombreUsuario == usuario);
                    if ((contrasenia == usua.Contrasena))
                    {
                        PantallaAdmin pantallaAdmin = new PantallaAdmin();
                        pantallaAdmin.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
               
            }
        }
    }
}

