using System;
using System.Collections.Generic;

namespace SistemaTransporte.Models;

public partial class Autobus
{
    public int IdAutobus { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public int? Capacidad { get; set; }

    //public virtual ICollection<Transporte> Transportes { get; set; } = new List<Transporte>();
}
