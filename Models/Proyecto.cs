using System;
using System.Collections.Generic;

namespace gestion_proyectos.Models
{
    public partial class Proyecto
    {
        public int Idproyecto { get; set; }
        public string Pr { get; set; }
        public string Proyecto1 { get; set; }
        public string Odc { get; set; }
        public int? Idfabrica { get; set; }
        public int? Idanalista { get; set; }
        public int? Idchecklist { get; set; }
        public DateTime? Fechamov { get; set; }
        public bool? Activo { get; set; }
    }
}
