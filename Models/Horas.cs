using System;
using System.Collections.Generic;

namespace gestion_proyectos.Models
{
    public partial class Horas
    {
        public int Idhoras { get; set; }
        public string Prj { get; set; }
        public string Nombre { get; set; }
        public string Componente { get; set; }
        public int Actividad { get; set; }
        public string Descripción { get; set; }
        public int Horasreportadas { get; set; }
        public DateTime Fechamov { get; set; }
        public bool Activo { get; set; }
    }
}
