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
using System.Xml.Linq;

namespace inventario.Views
{
    /// <summary>
    /// Lógica de interacción para Pantalla_devolucion.xaml
    /// </summary>
    public partial class Pantalla_devolucion : Page
    {
        private readonly int _prestamoId;
        private List<EstadoPrestamo> _prestamo;

        public Pantalla_devolucion(int prestamo_id)
        {
            InitializeComponent();
            _prestamoId = prestamo_id;
            cargarDatos();
            cargarValorescombobox();

        }
        public void cargarDatos()
        {
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                _prestamo = db.EstadoPrestamos.ToList();
                
                // Asignar los datos a los ComboBox
                combo_prestamo.ItemsSource = _prestamo;
                combo_prestamo.SelectedValuePath = "Id";
                combo_prestamo.DisplayMemberPath = " NombreEstadoPrestamo";



            }
        }
        public void cargarValorescombobox()
        {
            using (var db = new SenaInventarioContext())
            {
                var producto = db.Prestamos.Find(_prestamoId); // Pasar filtro

                // Obtener el nombre de la persona asociada al préstamo
                var personaNombre = db.Personas.Where(p => p.Id == producto.IdPersonaPrestamo)
                                              .Select(p => p.Nombre)
                                              .FirstOrDefault();

          
          
                // Seleccionar los elementos correspondientes en los ComboBox
                combo_prestamo.SelectedItem = _prestamo.FirstOrDefault(c => c.Id == producto.IdEstadoPrestamo);

                // Asignar el nombre de la persona al control de texto
                tex_persona_prestamo.Text = personaNombre;
            }
        }
        private void btncanecelar_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new SenaInventarioContext())
            {
                var producto = db.Prestamos.Find(_prestamoId);

             
                producto.IdEstadoPrestamo = (combo_prestamo.SelectedItem as EstadoPrestamo).Id;
               

                db.SaveChanges();
                MessageBox.Show("Devolucion cancelada con ", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService navService = NavigationService.GetNavigationService(this);
                navService?.Navigate(new Historial_prestamo_portero());
            }
        }
    }
}
