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

namespace inventario.Views
{
    /// <summary>
    /// Lógica de interacción para Editar_producto.xaml
    /// </summary>
    public partial class Editar_producto : Page
    {

        private readonly int _productoId;
        private List<Categoria> _categorias;
        private List<Persona> _personasEncargadas;
        private List<EstadoElemento> _estadosElemento;

        public Editar_producto(int productoId)
        {
            InitializeComponent();
            _productoId = productoId;
            CargarDatosIniciales();
            CargarDatosProducto();
        }

        private void CargarDatosIniciales()
        {
            using (var db = new SenaInventarioContext())
            {
                _categorias = db.Categorias.ToList();
                _personasEncargadas = db.Personas.ToList();
                _estadosElemento = db.EstadoElementos.ToList();

                // Asignar los datos a los ComboBox
                categoria.ItemsSource = _categorias;
                categoria.SelectedValuePath = "Id";
                categoria.DisplayMemberPath = "NombreCategoria";

                persona_encargada.ItemsSource = _personasEncargadas;
                persona_encargada.SelectedValuePath = "Id";
                persona_encargada.DisplayMemberPath = "Nombre";

                estado.ItemsSource = _estadosElemento;
                estado.SelectedValuePath = "Id";
                estado.DisplayMemberPath = "NombreEstadoElemento";
            }
        }

        private void CargarDatosProducto()
        {
            using (var db = new SenaInventarioContext())
            {
                var producto = db.Elementos.Find(_productoId);

                // Asignar los valores del producto a los controles de edición
                txt_nombre.Text = producto.NombreElemento;
                codigo_txt.Text = producto.CodigoElemento;
                txt_cantidad.Text = producto.Cantidad.ToString();

                // Seleccionar los elementos correspondientes en los ComboBox
                categoria.SelectedItem = _categorias.FirstOrDefault(c => c.Id == producto.IdCategoria);
                persona_encargada.SelectedItem = _personasEncargadas.FirstOrDefault(p => p.Id == producto.IdPersonaEncargada);
                estado.SelectedItem = _estadosElemento.FirstOrDefault(e => e.Id == producto.IdEstado);
            }
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new SenaInventarioContext())
            {
                var producto = db.Elementos.Find(_productoId);

                // Actualizar los valores del producto
                producto.NombreElemento = txt_nombre.Text;
                producto.CodigoElemento = codigo_txt.Text;
                producto.Cantidad = int.Parse(txt_cantidad.Text);
                producto.IdCategoria = (categoria.SelectedItem as Categoria).Id;
                producto.IdPersonaEncargada = (persona_encargada.SelectedItem as Persona).Id;
                producto.IdEstado = (estado.SelectedItem as EstadoElemento).Id;

                db.SaveChanges();
                MessageBox.Show("Producto actualizado correctamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService navService = NavigationService.GetNavigationService(this);
                navService?.Navigate(new Categoria_todos_admin());
            }
        }

        private void codigo_txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void persona_encargada_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void categoria_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txt_cantidad_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void estado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
