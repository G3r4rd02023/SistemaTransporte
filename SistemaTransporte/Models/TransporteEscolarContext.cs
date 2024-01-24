using Microsoft.EntityFrameworkCore;

namespace SistemaTransporte.Models;

public partial class TransporteEscolarContext : DbContext
{
    public TransporteEscolarContext()
    {
    }

    public TransporteEscolarContext(DbContextOptions<TransporteEscolarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autobus> Autobus { get; set; }

    public virtual DbSet<Conductor> Conductor { get; set; }

    public virtual DbSet<Escuela> Escuelas { get; set; }

    public virtual DbSet<Estudiante> Estudiante { get; set; }

    public virtual DbSet<Ruta> Ruta { get; set; }

    public virtual DbSet<Transporte> Transporte { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autobus>(entity =>
        {
            entity.HasKey(e => e.IdAutobus).HasName("PK__Autobus__DFD744760E6920C5");

            entity.Property(e => e.Marca)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Conductor>(entity =>
        {
            entity.HasKey(e => e.IdConductor).HasName("PK__Conducto__D6D296034769E8E4");

            entity.ToTable("Conductor");

            entity.Property(e => e.Licencia)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Escuela>(entity =>
        {
            entity.HasKey(e => e.IdEscuela).HasName("PK__Escuela__D6C6BBF5A8AC4F71");

            entity.ToTable("Escuela");

            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.IdEstudiante).HasName("PK__Estudian__B5007C2431BB680C");

            entity.ToTable("Estudiante");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Grado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);

            //entity.HasOne(d => d.IdEscuelaNavigation).WithMany(p => p.Estudiantes)
            //    .HasForeignKey(d => d.IdEscuela)
            //    .HasConstraintName("FK__Estudiant__IdEsc__38996AB5");
        });

        modelBuilder.Entity<Ruta>(entity =>
        {
            entity.HasKey(e => e.IdRuta).HasName("PK__Ruta__887538FE86F537C0");

            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Distancia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Horario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Origen)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Transporte>(entity =>
        {
            entity.HasKey(e => e.IdTransporte).HasName("PK__Transpor__E4C426F5B750DA19");

            entity.ToTable("Transporte");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            //entity.HasOne(d => d.IdAutobusNavigation).WithMany(p => p.Transportes)
            //    .HasForeignKey(d => d.IdAutobus)
            //    .HasConstraintName("FK__Transport__IdAut__4316F928");

            //entity.HasOne(d => d.IdConductorNavigation).WithMany(p => p.Transportes)
            //    .HasForeignKey(d => d.IdConductor)
            //    .HasConstraintName("FK__Transport__IdCon__440B1D61");

            //entity.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.Transportes)
            //    .HasForeignKey(d => d.IdEstudiante)
            //    .HasConstraintName("FK__Transport__IdEst__412EB0B6");

            //entity.HasOne(d => d.IdRutaNavigation).WithMany(p => p.Transportes)
            //    .HasForeignKey(d => d.IdRuta)
            //    .HasConstraintName("FK__Transport__IdRut__4222D4EF");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
