using System;
using System.Collections.Generic;

namespace SistemaTransporte.Models;

public partial class Transporte
{
    public int IdTransporte { get; set; }

    public int? IdEstudiante { get; set; }

    public int? IdRuta { get; set; }

    public int? IdAutobus { get; set; }

    public int? IdConductor { get; set; }

    public DateTime? Fecha { get; set; }

    //public virtual Autobus? IdAutobusNavigation { get; set; }

    //public virtual Conductor? IdConductorNavigation { get; set; }

    //public virtual Estudiante? IdEstudianteNavigation { get; set; }

    //public virtual Ruta? IdRutaNavigation { get; set; }
}
