using inventario.models;
using System;
using System.Collections.Generic;
using System.Globalization;
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

using System.Net.Mail;
namespace inventario.Views
{
    /// <summary>
    /// Lógica de interacción para Registro_prestamo.xaml
    /// </summary>
    public partial class Registro_prestamo : Page
    {
        private int userId;
        private const int estado_ini = 1;
        public Registro_prestamo(int userId)
        {
            this.userId = userId;
           

            InitializeComponent();
            DateTime fecha_actual = DateTime.Now;
            fecha_pres.Text = fecha_actual.ToString("yyyy-MM-dd HH:mm:ss");
            
        }
       


        private void btn_registro_persona(object sender, RoutedEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService?.Navigate(new Registro_personas_portero());

        }

        private void validar_btn_Click_1(object sender, RoutedEventArgs e)
        {
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                Prestamo nuevo_prestamo = new Prestamo();

                // Obtener el ID de la persona a partir del número de documento
                int personaId = db.Personas.Where(p => p.NumeroDocumento == documento_persona.Text)
                                          .Select(p => p.Id)
                                          .FirstOrDefault();
                if (personaId == 0)
                {
                    MessageBox.Show("Documento no existe, verifique que esté registrado");
                    return;
                }

                // Obtener el ID del elemento a través del código del elemento
                int elementoId = db.Elementos.Where(e => e.CodigoElemento == codigo_serial_txt.Text)
                                            .Select(e => e.Id)
                                            .FirstOrDefault();
                if (elementoId == 0)
                {
                    MessageBox.Show("Verifique que el código del elemento esté registrado");
                    return;
                }

                // Obtener el ID del funcionario a partir del número de documento
                var funcionarioAutorizacionId = db.Personas.Where(p => p.NumeroDocumento == txtdocuemnto_fun.Text)
                                                          .Select(p => p.Id)
                                                          .FirstOrDefault();
                if (funcionarioAutorizacionId == 0)
                {
                    MessageBox.Show("El funcionario no está registrado");
                    return;
                }

                try
                {
                    // Obtener la fecha actual
                    DateTime fecha_actual = DateTime.Now;
                    fecha_pres.Text = fecha_actual.ToString("yyyy-MM-dd HH:mm:ss");

                    // Validar que la fecha de devolución sea posterior a la fecha actual
                    if (fecha_devolucion.SelectedDate <= fecha_actual)
                    {
                        MessageBox.Show("La fecha de devolución debe ser posterior a la fecha actual");
                        return;
                    }

                    nuevo_prestamo.IdPersonaPrestamo = personaId;
                    nuevo_prestamo.FechaLimite = (DateTime)fecha_devolucion.SelectedDate;
                    nuevo_prestamo.IdEstadoPrestamo = estado_ini;
                    nuevo_prestamo.IdElemento = elementoId;
                    nuevo_prestamo.IdFuncionarioAutorizacion = funcionarioAutorizacionId;
                    nuevo_prestamo.IdPortero = userId;

                    db.Prestamos.Add(nuevo_prestamo);
                    db.SaveChanges();

                    MessageBox.Show("Se ha realizado el préstamo");
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }
    }
}
