using System;
using System.Collections.Generic;

namespace SistemaTransporte.Models;

public partial class Ruta
{
    public int IdRuta { get; set; }

    public string? Origen { get; set; }

    public string? Destino { get; set; }

    public string? Distancia { get; set; }

    public string? Horario { get; set; }

    //public virtual ICollection<Transporte> Transportes { get; set; } = new List<Transporte>();
}
