using System;
using System.Collections.Generic;

namespace inventario.models;

public partial class FotoElemento
{
    public int Id { get; set; }

    public string? RutaImagen { get; set; }

    public int? IdElemento { get; set; }

    public virtual Elemento? IdElementoNavigation { get; set; }
}
