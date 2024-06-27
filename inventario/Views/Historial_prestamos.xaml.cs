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
        }
        //public void buscar_documento()
        //{
        //    string documento = txtbuscado.Text.Trim();
        //    using (SenaInventarioContext db = new SenaInventarioContext())
        //    {
        //        var consulta = from persona in db.Personas
        //                       join prestamo in db.Prestamos on persona.Id equals prestamo.IdPersonaPrestamo
        //                       join elemento in db.Elementos on prestamo.IdElemento equals elemento.Id
        //                       join estado_elemento in db.EstadoElementos on elemento.IdEstado equals estado_elemento.Id
        //                       join estado_prestamo in db.EstadoPrestamos on prestamo.IdEstadoPrestamo equals estado_prestamo.Id
        //                       where persona.NumeroDocumento.ToLower() == documento.ToLower()
        //                       select new
        //                       {
        //                           cd = persona.Nombre,
        //                           nm = prestamo.FechaHoraPrestamo,
        //                           ec = prestamo.FechaLimite,
        //                           pn= elemento.NombreElemento,
        //                           es = estado_elemento.NombreEstadoElemento,
        //                           cg = db.Personas.FirstOrDefault(p => p.Id == elemento.IdPersonaEncargada)?.Nombre,
        //                           ep =estado_prestamo.NombreEstadoPrestamo
                                 
        //                       };

        //        datagrid_historial.ItemsSource = consulta.ToList();
        //    }
        //}

        //obtener id del datagrid para que modificar el estado del prestamo del producto
        private void txtbuscado_TextChanged(object sender, TextChangedEventArgs e)
        {
            //buscar_documento();

        }
    }
}
