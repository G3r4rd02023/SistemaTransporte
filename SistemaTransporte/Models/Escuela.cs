using System;
using System.Collections.Generic;

namespace SistemaTransporte.Models;

public partial class Escuela
{
    public int IdEscuela { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    //public virtual ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
}
