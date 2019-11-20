using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace gestion_proyectos.Models
{
    public partial class ProyectosContext : DbContext
    {
        public ProyectosContext()
        {
        }

        public ProyectosContext(DbContextOptions<ProyectosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<Analista> Analista { get; set; }
        public virtual DbSet<Applog> Applog { get; set; }
        public virtual DbSet<Checklist> Checklist { get; set; }
        public virtual DbSet<Fabrica> Fabrica { get; set; }
        public virtual DbSet<Horas> Horas { get; set; }
        public virtual DbSet<Proyecto> Proyecto { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=EAYICANCAR\\SQLEXPRESS;Initial Catalog=Proyectos;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Actividad>(entity =>
            {
                entity.HasKey(e => e.Idactividad)
                    .HasName("PK__activida__CBE32A3BB6EA52B8");

                entity.ToTable("actividad");

                entity.Property(e => e.Actividad1)
                    .IsRequired()
                    .HasColumnName("actividad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Fechamov)
                    .HasColumnName("fechamov")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Analista>(entity =>
            {
                entity.HasKey(e => e.Idanalista)
                    .HasName("PK__analista__959CDDB03446A887");

                entity.ToTable("analista");

                entity.Property(e => e.Idanalista).HasColumnName("idanalista");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Analista1)
                    .HasColumnName("analista")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fechamov)
                    .HasColumnName("fechamov")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Applog>(entity =>
            {
                entity.HasKey(e => e.Idapplog)
                    .HasName("PK__applog__8AEA376936C2CEB3");

                entity.ToTable("applog");

                entity.Property(e => e.Idapplog).HasColumnName("idapplog");

                entity.Property(e => e.Applog1)
                    .HasColumnName("applog")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Fechamov)
                    .HasColumnName("fechamov")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Checklist>(entity =>
            {
                entity.HasKey(e => e.Idchecklist)
                    .HasName("PK__checklis__37FB770B1A158FFC");

                entity.ToTable("checklist");

                entity.Property(e => e.Idchecklist).HasColumnName("idchecklist");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Analisiscosto)
                    .HasColumnName("analisiscosto")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Analisisdesviacion)
                    .HasColumnName("analisisdesviacion")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Analisisdocto).HasColumnName("analisisdocto");

                entity.Property(e => e.Analisisfecfin)
                    .HasColumnName("analisisfecfin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Analisisfecini)
                    .HasColumnName("analisisfecini")
                    .HasColumnType("datetime");

                entity.Property(e => e.Analisishrs).HasColumnName("analisishrs");

                entity.Property(e => e.Cotizacion).HasColumnName("cotizacion");

                entity.Property(e => e.Diseniocosto)
                    .HasColumnName("diseniocosto")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Diseniodesviacion)
                    .HasColumnName("diseniodesviacion")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Diseniodocto).HasColumnName("diseniodocto");

                entity.Property(e => e.Diseniofecfin)
                    .HasColumnName("diseniofecfin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Diseniofecini)
                    .HasColumnName("diseniofecini")
                    .HasColumnType("datetime");

                entity.Property(e => e.Diseniohrs).HasColumnName("diseniohrs");

                entity.Property(e => e.Etapa)
                    .HasColumnName("etapa")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Fechafin)
                    .HasColumnName("fechafin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechamov)
                    .HasColumnName("fechamov")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fehcaini)
                    .HasColumnName("fehcaini")
                    .HasColumnType("datetime");

                entity.Property(e => e.Porducciondesviacion)
                    .HasColumnName("porducciondesviacion")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Produccion).HasColumnName("produccion");

                entity.Property(e => e.Qaciclo).HasColumnName("qaciclo");

                entity.Property(e => e.Qacosto)
                    .HasColumnName("qacosto")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qadesviacion)
                    .HasColumnName("qadesviacion")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Qadocto).HasColumnName("qadocto");

                entity.Property(e => e.Qafecfin)
                    .HasColumnName("qafecfin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Qafecini)
                    .HasColumnName("qafecini")
                    .HasColumnType("datetime");

                entity.Property(e => e.Qahrs).HasColumnName("qahrs");

                entity.Property(e => e.Recursos)
                    .HasColumnName("recursos")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Recursoscant).HasColumnName("recursoscant");
            });

            modelBuilder.Entity<Fabrica>(entity =>
            {
                entity.HasKey(e => e.Idfabrica)
                    .HasName("PK__fabrica__F7DAA0E075DC9ECC");

                entity.ToTable("fabrica");

                entity.Property(e => e.Idfabrica).HasColumnName("idfabrica");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Fabrica1)
                    .HasColumnName("fabrica")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fechamov)
                    .HasColumnName("fechamov")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Horas>(entity =>
            {
                entity.HasKey(e => e.Idhoras)
                    .HasName("PK__horas__DFB4EA390997B936");

                entity.ToTable("horas");

                entity.Property(e => e.Idhoras).HasColumnName("idhoras");

                entity.Property(e => e.Actividad).HasColumnName("actividad");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Componente)
                    .IsRequired()
                    .HasColumnName("componente")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripción)
                    .IsRequired()
                    .HasColumnName("descripción")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fechamov)
                    .HasColumnName("fechamov")
                    .HasColumnType("datetime");

                entity.Property(e => e.Horasreportadas).HasColumnName("horasreportadas");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prj)
                    .IsRequired()
                    .HasColumnName("prj")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Proyecto>(entity =>
            {
                entity.HasKey(e => e.Idproyecto)
                    .HasName("PK__proyecto__F576AC82AF3F78EB");

                entity.ToTable("proyecto");

                entity.Property(e => e.Idproyecto).HasColumnName("idproyecto");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Fechamov)
                    .HasColumnName("fechamov")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idanalista).HasColumnName("idanalista");

                entity.Property(e => e.Idchecklist).HasColumnName("idchecklist");

                entity.Property(e => e.Idfabrica).HasColumnName("idfabrica");

                entity.Property(e => e.Odc)
                    .HasColumnName("odc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pr)
                    .HasColumnName("pr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Proyecto1)
                    .HasColumnName("proyecto")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("PK__usuario__080A974314DCC2D1");

                entity.ToTable("usuario");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Fechamov)
                    .HasColumnName("fechamov")
                    .HasColumnType("datetime");

                entity.Property(e => e.Usuario1)
                    .HasColumnName("usuario")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
