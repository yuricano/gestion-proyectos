using System;
using System.Collections.Generic;

namespace gestion_proyectos.Models
{
    public partial class Usuario
    {
        public int Idusuario { get; set; }
        public string Usuario1 { get; set; }
        public DateTime? Fechamov { get; set; }
        public bool? Activo { get; set; }
    }
}
