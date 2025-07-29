using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Inmobiliaria.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    #region Generated Properties
    public virtual DbSet<Inmobiliaria.Data.Entities.Contratos> Contratos { get; set; } = null!;

    public virtual DbSet<Inmobiliaria.Data.Entities.Documentos> Documentos { get; set; } = null!;

    public virtual DbSet<Inmobiliaria.Data.Entities.Garantias> Garantias { get; set; } = null!;

    public virtual DbSet<Inmobiliaria.Data.Entities.Inquilinos> Inquilinos { get; set; } = null!;

    public virtual DbSet<Inmobiliaria.Data.Entities.Pagos> Pagos { get; set; } = null!;

    public virtual DbSet<Inmobiliaria.Data.Entities.Propiedades> Propiedades { get; set; } = null!;

    public virtual DbSet<Inmobiliaria.Data.Entities.Propietarios> Propietarios { get; set; } = null!;

    public virtual DbSet<Inmobiliaria.Data.Entities.Tenants> Tenants { get; set; } = null!;

    public virtual DbSet<Inmobiliaria.Data.Entities.UnidadesFuncionales> UnidadesFuncionales { get; set; } = null!;

    public virtual DbSet<Inmobiliaria.Data.Entities.Usuarios> Usuarios { get; set; } = null!;

    public virtual DbSet<Inmobiliaria.Data.Entities.VContratosActivos> VContratosActivos { get; set; } = null!;

    public virtual DbSet<Inmobiliaria.Data.Entities.VUnidadesCompleta> VUnidadesCompleta { get; set; } = null!;

    #endregion
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Generated Configuration
        modelBuilder.ApplyConfiguration(new Inmobiliaria.Data.Mapping.PG.ContratosMap());
        modelBuilder.ApplyConfiguration(new Inmobiliaria.Data.Mapping.PG.DocumentosMap());
        modelBuilder.ApplyConfiguration(new Inmobiliaria.Data.Mapping.PG.GarantiasMap());
        modelBuilder.ApplyConfiguration(new Inmobiliaria.Data.Mapping.PG.InquilinosMap());
        modelBuilder.ApplyConfiguration(new Inmobiliaria.Data.Mapping.PG.PagosMap());
        modelBuilder.ApplyConfiguration(new Inmobiliaria.Data.Mapping.PG.PropiedadesMap());
        modelBuilder.ApplyConfiguration(new Inmobiliaria.Data.Mapping.PG.PropietariosMap());
        modelBuilder.ApplyConfiguration(new Inmobiliaria.Data.Mapping.PG.TenantsMap());
        modelBuilder.ApplyConfiguration(new Inmobiliaria.Data.Mapping.PG.UnidadesFuncionalesMap());
        modelBuilder.ApplyConfiguration(new Inmobiliaria.Data.Mapping.PG.UsuariosMap());
        modelBuilder.ApplyConfiguration(new Inmobiliaria.Data.Mapping.PG.VContratosActivosMap());
        modelBuilder.ApplyConfiguration(new Inmobiliaria.Data.Mapping.PG.VUnidadesCompletaMap());
        #endregion
    }
}
