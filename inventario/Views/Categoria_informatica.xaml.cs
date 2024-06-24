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
    /// Lógica de interacción para Categoria_informatica.xaml
    /// </summary>
    public partial class Categoria_informatica : Page
    {
        public Categoria_informatica()
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
                            where categoria.NombreCategoria.ToLower() == "Informatica"
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
                data_productos_informatica.ItemsSource = query.ToList();
            }
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
                            where categoria.NombreCategoria.ToLower() == "informatica" &&
                                  (elementos.CodigoElemento.Contains(txtbuscar) || elementos.NombreElemento.Contains(txtbuscar))
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
                data_productos_informatica.ItemsSource = query.ToList();
            }
        }

        

        private void data_productos_informatica_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtbuscado_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            buscarDatos();
        }
    }
}
