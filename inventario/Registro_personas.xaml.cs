using inventario.Models;
using inventario.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Linq;


namespace inventario
{
    /// <summary>
    /// Lógica de interacción para Registro_personas.xaml
    /// </summary>
    public partial class Registro_personas : Page
    {
        public Registro_personas()
        {
            InitializeComponent();
        }

        public void registrar_perso()
        {
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(nombre_txt.Text) ||
                        string.IsNullOrWhiteSpace(apellido_txt.Text) ||
                        string.IsNullOrWhiteSpace(email_txt.Text) ||
                        string.IsNullOrWhiteSpace(numero_documento_txt.Text))
                    {
                        MessageBox.Show("Todos los campos son obligatorios.", "Error de validación");
                        return;
                    }

                    // Validar el formato del correo electrónico
                    if (!IsValidEmail(email_txt.Text))
                    {
                        MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error de validación");
                        return;
                    }

                    // Validar que el número de documento tenga 10 dígitos
                    if (!IsValidDocumentNumber(numero_documento_txt.Text))
                    {
                        MessageBox.Show("El número de documento debe tener 10 dígitos.", "Error de validación");
                        return;
                    }
                    if (db.Personas.Any(p => p.NumeroDocumento == numero_documento_txt.Text))
                    {
                        MessageBox.Show("El número de documento ya está registrado.", "Error de validación");
                        return;
                    }

  
                    if (db.Personas.Any(p => p.Correo == email_txt.Text))
                    {
                        MessageBox.Show("El correo electrónico ya está registrado.", "Error de validación");
                        return;
                    }

                    Persona persona = new Persona
                    {
                        Nombre = nombre_txt.Text,
                        Apellido = apellido_txt.Text,
                        Correo = email_txt.Text,
                        NumeroDocumento = numero_documento_txt.Text
                    };

                    db.Personas.Add(persona);
                    db.SaveChanges();
                    MessageBox.Show("Registro exitoso.", "Confirmación de registro");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error");
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidDocumentNumber(string documentNumber)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(documentNumber, pattern);
        }

        private void btn_registro_Click(object sender, RoutedEventArgs e)
        {
            registrar_perso();
        }

        

        private void btnusuario_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService?.Navigate(new Registrar_usuario());
        }
    }
}
