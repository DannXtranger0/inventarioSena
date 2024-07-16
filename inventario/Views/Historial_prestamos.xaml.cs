using inventario.models;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace inventario.Views
{
    /// <summary>
    /// Interaction logic for Historial_prestamos.xaml
    /// </summary>
    public partial class Historial_prestamos : Page
    {
        public Historial_prestamos()
        {
            InitializeComponent();
            CargarDatos();
        }
        public void CargarDatos()
        {
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                var datos = from prestamo in db.Prestamos
                            join estado_prestamo in db.EstadoPrestamos on prestamo.IdEstadoPrestamo equals estado_prestamo.Id
                            join persona in db.Personas on prestamo.IdPersonaPrestamo equals persona.Id
                            join elemento in db.Elementos on prestamo.IdElemento equals elemento.Id
                            select new
                            {
                                id = prestamo.Id,
                                es = persona.NumeroDocumento,
                                cd = persona.Nombre,
                                ex = prestamo.FechahoraPrestamo,
                                ec = prestamo.FechaLimite.ToString("yyyy-MM-dd"),
                                pn = elemento.NombreElemento,
                                cg = estado_prestamo.NombreEstadoPrestamo,
                                sp = db.Personas.Where(p => p.Id == prestamo.IdElemento).Select(p => p.Nombre).FirstOrDefault()

                            };

                datagridhistorial.ItemsSource = datos.ToList();
            }
        }

       

        private void data_productos_historial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void txtbuscado_TextChanged(object sender, TextChangedEventArgs e)
        {

            var buscar = txtbuscado.Text.Trim();
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                var datos = from prestamo in db.Prestamos
                            join estado_prestamo in db.EstadoPrestamos on prestamo.IdEstadoPrestamo equals estado_prestamo.Id
                            join persona in db.Personas on prestamo.IdPersonaPrestamo equals persona.Id
                            join elemento in db.Elementos on prestamo.IdElemento equals elemento.Id
                            where persona.NumeroDocumento.Contains(buscar) || persona.Nombre.Contains(buscar)
                            select new
                            {
                                id = prestamo.Id,
                                es = persona.NumeroDocumento,
                                cd = persona.Nombre,
                                ex = prestamo.FechahoraPrestamo,
                                ec = prestamo.FechaLimite.ToString("yyyy-MM-dd"),
                                pn = elemento.NombreElemento,
                                cg = estado_prestamo.NombreEstadoPrestamo,
                                sp = db.Personas.Where(p => p.Id == prestamo.IdElemento).Select(p => p.Nombre).FirstOrDefault()


                            };
                datagridhistorial.ItemsSource = datos.ToList();
            }
        }

        private void datagridhistorial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                using (SenaInventarioContext db = new SenaInventarioContext())
                {
                    if (datagridhistorial.SelectedItem != null)
                    {
                        int id = (int)((dynamic)datagridhistorial.SelectedItem).id;
                        NavigationService navService = NavigationService.GetNavigationService(this);
                        navService?.Navigate(new Pantalla_devolucion(id));

                    }
                    else
                    {
                        MessageBox.Show("No se seleccionó ningún registro.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
 
    }

