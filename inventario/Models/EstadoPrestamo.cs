using System;
using System.Collections.Generic;

namespace inventario.Models;

public partial class EstadoPrestamo
{
    public int Id { get; set; }

    public string? NombreEstadoPrestamo { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
