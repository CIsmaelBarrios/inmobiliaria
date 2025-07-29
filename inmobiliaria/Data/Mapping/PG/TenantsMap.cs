using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Mapping.PG;

public partial class TenantsMap
    : IEntityTypeConfiguration<Inmobiliaria.Data.Entities.Tenants>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inmobiliaria.Data.Entities.Tenants> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("tenants", "public");

        // key
        builder.HasKey(t => t.IdTenant);

        // properties
        builder.Property(t => t.IdTenant)
            .IsRequired()
            .HasColumnName("id_tenant")
            .HasColumnType("uuid")
            .HasDefaultValueSql("uuid_generate_v4()");

        builder.Property(t => t.Nombre)
            .IsRequired()
            .HasColumnName("nombre")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

        builder.Property(t => t.Cuit)
            .HasColumnName("cuit")
            .HasColumnType("character varying(13)")
            .HasMaxLength(13);

        builder.Property(t => t.Email)
            .HasColumnName("email")
            .HasColumnType("character varying(150)")
            .HasMaxLength(150);

        builder.Property(t => t.Telefono)
            .HasColumnName("telefono")
            .HasColumnType("character varying(20)")
            .HasMaxLength(20);

        builder.Property(t => t.Direccion)
            .HasColumnName("direccion")
            .HasColumnType("text");

        builder.Property(t => t.Activo)
            .IsRequired()
            .HasColumnName("activo")
            .HasColumnType("boolean")
            .HasDefaultValue(true);

        builder.Property(t => t.FechaCreacion)
            .IsRequired()
            .HasColumnName("fecha_creacion")
            .HasColumnType("timestamp without time zone")
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.Property(t => t.FechaActualizacion)
            .IsRequired()
            .HasColumnName("fecha_actualizacion")
            .HasColumnType("timestamp without time zone")
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.Property(t => t.Eliminado)
            .IsRequired()
            .HasColumnName("eliminado")
            .HasColumnType("boolean")
            .HasDefaultValue(false);

        builder.Property(t => t.FechaEliminacion)
            .HasColumnName("fecha_eliminacion")
            .HasColumnType("timestamp without time zone");

        // relationships
        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "tenants";
    }

    public readonly struct Columns
    {
        public const string IdTenant = "id_tenant";
        public const string Nombre = "nombre";
        public const string Cuit = "cuit";
        public const string Email = "email";
        public const string Telefono = "telefono";
        public const string Direccion = "direccion";
        public const string Activo = "activo";
        public const string FechaCreacion = "fecha_creacion";
        public const string FechaActualizacion = "fecha_actualizacion";
        public const string Eliminado = "eliminado";
        public const string FechaEliminacion = "fecha_eliminacion";
    }
    #endregion
}
