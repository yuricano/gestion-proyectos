using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace gestion_proyectos.Models
{
    public class ProyectosDataAccessLayer
    {
        ProyectosContext db = new ProyectosContext();

        public IEnumerable<Actividad> GetAllEmployees()
        {
            try
            {
                return db.Actividad.ToList();
            }
            catch
            {
                throw;
            }
        }

        // Ins actividad
        public int InsActividad(Actividad actividad)
        {
            try
            {
                db.Actividad.Add(actividad);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        // Upd Actividad 
        public int UpdActividad(Actividad actividad)
        {
            try
            {
                db.Entry(actividad).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        // Get particular Actividad
        public Actividad GetActividadData(int id)
        {
            try
            {
                Actividad actividad = db.Actividad.Find(id);
                return actividad;
            }
            catch
            {
                throw;
            }
        }

        // Del Actividad  
        public int DelActividad(int id)
        {
            try
            {
                Actividad reg = db.Actividad.Find(id);
                db.Actividad.Remove(reg);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        // Get todas las Actividades
        public List<Actividad> GetActividades()
        {
            List<Actividad> lstActividad = new List<Actividad>();
            lstActividad = (from ActividadList in db.Actividad  select ActividadList).ToList();

            return lstActividad;
        }
    }
}
 