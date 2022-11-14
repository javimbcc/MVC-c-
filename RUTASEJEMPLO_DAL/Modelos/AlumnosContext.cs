using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RUTASEJEMPLO_DAL.Modelos;

public partial class AlumnosContext : DbContext
{
    public AlumnosContext()
    {
    }

    public AlumnosContext(DbContextOptions<AlumnosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Alumnos;User Id=postgres;Password=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Alumnos_pkey");

            entity.ToTable("Alumnos", "EjemploRutas", tb => tb.HasComment("Entidad que regula los alumnos"));

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.AlumnoApellido1)
                .HasColumnType("character varying")
                .HasColumnName("alumno_apellido1");
            entity.Property(e => e.AlumnoApellido2)
                .HasColumnType("character varying")
                .HasColumnName("alumno_apellido2");
            entity.Property(e => e.AlumnoCorreo)
                .HasColumnType("character varying")
                .HasColumnName("alumno_correo");
            entity.Property(e => e.AlumnoEdad).HasColumnName("alumno_edad");
            entity.Property(e => e.AlumnoFechaNacimiento)
                .HasColumnType("character varying")
                .HasColumnName("alumno_fecha_nacimiento");
            entity.Property(e => e.AlumnoNombre)
                .HasColumnType("character varying")
                .HasColumnName("alumno_nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
