using System;
using System.Collections.Generic;

namespace gestion_proyectos.Models
{
    public partial class Actividad
    {
        public int Idactividad { get; set; }
        public string Actividad1 { get; set; }
        public DateTime Fechamov { get; set; }
        public bool Activo { get; set; }
    }
}
