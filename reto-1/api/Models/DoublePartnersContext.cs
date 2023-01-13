using Microsoft.EntityFrameworkCore;

namespace DoublePartnersAPI.Models;

public partial class DoublePartnersContext : DbContext
{
    public DoublePartnersContext()
    {
    }

    public DoublePartnersContext(DbContextOptions<DoublePartnersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personas__3213E83F4F6D9AF5");

            entity.ToTable(tb => tb.HasComment("Almacena la información relacionada a las personas vinculadas a la plataforma"));

            entity.Property(e => e.Id)
                .HasComment("Identificador único de la persona en la tabla")
                .HasColumnName("id");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasComment("Apellidos completos de la persona")
                .HasColumnName("apellidos");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Dirección de correo electronico de la persona")
                .HasColumnName("email");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("fechaCreacion");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Número de identificación del DNI de la persona")
                .HasColumnName("identificacion");
            entity.Property(e => e.IdentificacionCompleta)
                .HasMaxLength(81)
                .IsUnicode(false)
                .HasComputedColumnSql("(concat([tipoIdentificacion],'-',[identificacion]))", false)
                .HasColumnName("identificacionCompleta");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(701)
                .IsUnicode(false)
                .HasComputedColumnSql("(concat([nombres],' ',[apellidos]))", false)
                .HasColumnName("nombreCompleto");
            entity.Property(e => e.Nombres)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasComment("Nombres completos de la persona")
                .HasColumnName("nombres");
            entity.Property(e => e.TipoIdentificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoIdentificacion");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3213E83F0AAF4FEA");

            entity.ToTable(tb => tb.HasComment("Guarda la información relacionada a los usuarios que se pueden registrar y autenticar en el sistema"));

            entity.HasIndex(e => e.Usuario1, "UQ__Usuarios__9AFF8FC63E04FAF2").IsUnique();

            entity.Property(e => e.Id)
                .HasComment("Identificador único del usuario en el sistema")
                .HasColumnName("id");
            entity.Property(e => e.Clave)
                .HasMaxLength(700)
                .HasComment("Clave de usuario cifrada")
                .HasColumnName("clave");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha de la creaicón del usuario en el sistema")
                .HasColumnType("datetime")
                .HasColumnName("fechaCreacion");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Identificador que utilizará el usuario para realizar actividades de autenticación")
                .HasColumnName("usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
