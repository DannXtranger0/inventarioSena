using inventario.models;
using inventario.Views;
using Microsoft.EntityFrameworkCore;
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
            contrasenia_show.Password = contrasenia_txt.Text; // S
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
                string usuario = txtUsername.Text;
                string contrasenia = contrasenia_show.Visibility == Visibility.Visible ? contrasenia_show.Password : contrasenia_txt.Text;

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenia))
                {
                    MessageBox.Show("Por favor, rellene todos los campos");
                    return;
                }

                try
                {
                    Usuario usua = db.Usuarios.Where(us => us.NombreUsuario == usuario && us.Contrasena == contrasenia).FirstOrDefault();

                    if (usua != null)
                    {
                        int id_usuario = usua.Id;

                        // validar que tipo de usuario unicia sesion 
                        Role rol = db.Roles.FirstOrDefault(r => r.Id == usua.IrRol);

                        if (rol != null)
                        {
                            if (rol.NombreRol == "Administrador")
                            {
                                //redirigir al admini
                                PantallaAdmin pantallaAdmin = new PantallaAdmin(id_usuario);
                                pantallaAdmin.Show();
                                this.Close();
                            }
                            else if (rol.NombreRol == "Portero")
                            {
                                //redirigir al portero
                                Pantalla_portero pantalla_Portero = new Pantalla_portero(id_usuario);
                                pantalla_Portero.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Tipo de usuario no válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tipo de usuario no encontrado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error en el sistema: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

  
    }
}

