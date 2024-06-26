using inventario.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
             GetRoles();
        }
        private void GetRoles()
        {
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                var rolesUsuario = db.Roles.ToList();
              
                roles_usuario.ItemsSource = rolesUsuario;
                roles_usuario.SelectedValuePath = "Id";
                roles_usuario.DisplayMemberPath = "NombreRol";

                
            }
        }

        private void CrearUsuario()
        {
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                Usuario nuevo_usuario = new Usuario();
                // Obtener el ID de la persona a partir del número de documento
                int personaId = db.Personas.Where(p => p.NumeroDocumento == documento_txt.Text)
                                          .Select(p => p.Id)
                                          .FirstOrDefault();

                 //mensaje de error si el numero de documento no esta registrado
                if (personaId==0)
                {
                    MessageBox.Show("El numero de documento no existe");
                }
                else
                {
                    nuevo_usuario.IdPersona = personaId;
                    nuevo_usuario.IrRol = ((Role)roles_usuario.SelectedItem).Id;
                    nuevo_usuario.NombreUsuario = txt_usuario.Text;
                    nuevo_usuario.Contrasena = contraseña_txt.Text;


                    db.Usuarios.Add(nuevo_usuario);
                    db.SaveChanges();
                    MessageBox.Show("Registro exitoso");
                }

            }
        }

        private void btn_registro_Click(object sender, RoutedEventArgs e)
        {
            CrearUsuario();
        }


       
    }
}
