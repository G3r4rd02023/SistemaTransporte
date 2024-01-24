using System;
using System.Collections.Generic;

namespace SistemaTransporte.Models;

public partial class Estudiante
{
    public int IdEstudiante { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Grado { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public int? IdEscuela { get; set; }

    //public virtual Escuela? IdEscuelaNavigation { get; set; }

    //public virtual ICollection<Transporte> Transportes { get; set; } = new List<Transporte>();
}
