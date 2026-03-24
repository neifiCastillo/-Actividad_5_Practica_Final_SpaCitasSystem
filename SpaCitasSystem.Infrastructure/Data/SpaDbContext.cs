using Microsoft.EntityFrameworkCore;
using SpaCitasSystem.Domain.Entities;
public class SpaDbContext : DbContext
{
    public SpaDbContext(DbContextOptions<SpaDbContext> options)
        : base(options)
    {
    }
    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Paciente> Pacientes { get; set; }

    public DbSet<Servicio> Servicios { get; set; }

    public DbSet<Terapeuta> Terapeutas { get; set; }

    public DbSet<Cita> Citas { get; set; }
}