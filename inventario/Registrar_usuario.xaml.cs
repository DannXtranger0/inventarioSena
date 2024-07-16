using inventario.models;
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
        //private int userId;
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


        private const int DOCUMENTO_NO_REGISTRADO = 0;

        private void CrearUsuario()
        {
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                try
                {
                    Usuario nuevoUsuario = new Usuario();
                    int personaId = db.Personas.Where(p => p.NumeroDocumento == documento_txt.Text)
                                              .Select(p => p.Id)
                                              .FirstOrDefault();

                    if (personaId == DOCUMENTO_NO_REGISTRADO)
                    {
                        MessageBox.Show("El número de documento no está registrado.");
                    }
                    else
                    {
                        nuevoUsuario.IdPersona = personaId;
                        nuevoUsuario.IrRol = ((Role)roles_usuario.SelectedItem).Id;
                        nuevoUsuario.NombreUsuario = txt_usuario.Text;
                        nuevoUsuario.Contrasena = contraseña_txt.Text;

                        db.Usuarios.Add(nuevoUsuario);
                        db.SaveChanges();
                        MessageBox.Show("Registro exitoso.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear usuario: {ex.Message}");
                }
            }
        }

       

        private void btn_registro_Click_1(object sender, RoutedEventArgs e)
        {
            CrearUsuario();
        }
    }
}
