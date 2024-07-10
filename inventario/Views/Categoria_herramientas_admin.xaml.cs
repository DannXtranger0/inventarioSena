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

namespace inventario.Views
{
    /// <summary>
    /// Interaction logic for Categoria_herramientas_admin.xaml
    /// </summary>
    public partial class Categoria_herramientas_admin : Page
    {
        public Categoria_herramientas_admin()
        {
            InitializeComponent();
            getElementos();
        }

        public void getElementos()
        {
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                var query = from elementos in db.Elementos
                            join categoria in db.Categorias on elementos.IdCategoria equals categoria.Id
                            join persona in db.Personas on elementos.IdPersonaEncargada equals persona.Id
                            join estado in db.EstadoElementos on elementos.IdEstado equals estado.Id
                            where categoria.NombreCategoria.ToLower() == "Herramientas"
                            select new
                            {
                                id = elementos.Id,
                                cd = elementos.CodigoElemento,
                                nm = elementos.NombreElemento,
                                ec = elementos.Cantidad,
                                pn = persona.Nombre,

                                es = estado.NombreEstadoElemento,
                                cg = categoria.NombreCategoria

                            };
                dataproductos.ItemsSource = query.ToList();

            };

        }
        public void buscarDatos()
        {
            var txtbuscar = txtbuscado.Text.Trim(); // Obtener el texto del cuadro de búsqueda
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                // Construir la consulta con filtro por código y nombre
                var query = from elementos in db.Elementos
                            join categoria in db.Categorias on elementos.IdCategoria equals categoria.Id
                            join persona in db.Personas on elementos.IdPersonaEncargada equals persona.Id
                            join estado in db.EstadoElementos on elementos.IdEstado equals estado.Id
                            where categoria.NombreCategoria.ToLower() == "herramientas" &&
                                   (elementos.CodigoElemento.Contains(txtbuscar) || elementos.NombreElemento.Contains(txtbuscar))
                            select new
                            {
                                cd = elementos.CodigoElemento,
                                nm = elementos.NombreElemento,
                                ec = elementos.Cantidad,
                                pn = persona.Nombre,
                                es = estado.NombreEstadoElemento,
                                cg = categoria.NombreCategoria
                            };
                dataproductos.ItemsSource = query.ToList(); // Asignar los resultados al origen de datos
            }

        }







        private void btneliminar_Click_1(object sender, RoutedEventArgs e)
        {
            using (SenaInventarioContext db = new SenaInventarioContext())
            {
                int id_elemento = (int)((Button)sender).CommandParameter;
                var elemento = db.Elementos.Find(id_elemento);
                if (elemento != null)
                {
                    var opcevaluar = MessageBox.Show($"¿Estás seguro de eliminar el elemento '{elemento.NombreElemento}'?", "Confirmación de eliminación", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (opcevaluar == MessageBoxResult.Yes)
                    {

                        db.Elementos.Remove(elemento);
                        db.SaveChanges();
                        getElementos();
                    }
                    //else
                    //{
                    //    MessageBox.Show("se cancelo la eliminacion");
                    //}
                }

            }
        }

        private void btneditar_Click(object sender, RoutedEventArgs e)
        {
            int id_elemento = (int)((Button)sender).CommandParameter;
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService?.Navigate(new Editar_producto(id_elemento));
        }



        private void btnagregar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService?.Navigate(new Agregar_producto());
        }


    }
}
