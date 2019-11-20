using System;
using System.Collections.Generic;

namespace gestion_proyectos.Models
{
    public partial class Analista
    {
        public int Idanalista { get; set; }
        public string Analista1 { get; set; }
        public DateTime? Fechamov { get; set; }
        public bool? Activo { get; set; }
    }
}
