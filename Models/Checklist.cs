using System;
using System.Collections.Generic;

namespace gestion_proyectos.Models
{
    public partial class Checklist
    {
        public int Idchecklist { get; set; }
        public bool? Cotizacion { get; set; }
        public DateTime? Fehcaini { get; set; }
        public DateTime? Fechafin { get; set; }
        public string Etapa { get; set; }
        public bool? Analisisdocto { get; set; }
        public int? Analisishrs { get; set; }
        public DateTime? Analisisfecini { get; set; }
        public DateTime? Analisisfecfin { get; set; }
        public decimal? Analisiscosto { get; set; }
        public string Analisisdesviacion { get; set; }
        public bool? Diseniodocto { get; set; }
        public int? Diseniohrs { get; set; }
        public DateTime? Diseniofecini { get; set; }
        public DateTime? Diseniofecfin { get; set; }
        public decimal? Diseniocosto { get; set; }
        public string Diseniodesviacion { get; set; }
        public bool? Qadocto { get; set; }
        public int? Qahrs { get; set; }
        public DateTime? Qafecini { get; set; }
        public DateTime? Qafecfin { get; set; }
        public decimal? Qacosto { get; set; }
        public int? Qaciclo { get; set; }
        public string Qadesviacion { get; set; }
        public bool? Produccion { get; set; }
        public string Porducciondesviacion { get; set; }
        public int? Recursoscant { get; set; }
        public string Recursos { get; set; }
        public DateTime? Fechamov { get; set; }
        public bool? Activo { get; set; }
    }
}
