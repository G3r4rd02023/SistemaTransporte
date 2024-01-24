using System;
using System.Collections.Generic;

namespace SistemaTransporte.Models;

public partial class Conductor
{
    public int IdConductor { get; set; }

    public string? Nombre { get; set; }

    public string? Licencia { get; set; }

    public string? Telefono { get; set; }

    //public virtual ICollection<Transporte> Transportes { get; set; } = new List<Transporte>();
}
