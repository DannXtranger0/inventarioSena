using System;
using System.Collections.Generic;

namespace inventario.models;

public partial class EstadoElemento
{
    public int Id { get; set; }

    public string? NombreEstadoElemento { get; set; }

    public virtual ICollection<Elemento> Elementos { get; set; } = new List<Elemento>();

    public virtual ICollection<EstadoElementosPrestamo> EstadoElementosPrestamos { get; set; } = new List<EstadoElementosPrestamo>();
}
