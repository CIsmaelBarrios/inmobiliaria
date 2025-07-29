using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Mapping.PG;

public partial class InquilinosMap
    : IEntityTypeConfiguration<Inmobiliaria.Data.Entities.Inquilinos>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inmobiliaria.Data.Entities.Inquilinos> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("inquilinos", "public");

        // key
        builder.HasKey(t => t.IdInquilino);

        // properties
        builder.Property(t => t.IdInquilino)
            .IsRequired()
            .HasColumnName("id_inquilino")
            .HasColumnType("uuid")
            .HasDefaultValueSql("uuid_generate_v4()");

        builder.Property(t => t.IdTenant)
            .IsRequired()
            .HasColumnName("id_tenant")
            .HasColumnType("uuid");

        builder.Property(t => t.Nombre)
            .IsRequired()
            .HasColumnName("nombre")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

        builder.Property(t => t.Apellido)
            .IsRequired()
            .HasColumnName("apellido")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

        builder.Property(t => t.Dni)
            .IsRequired()
            .HasColumnName("dni")
            .HasColumnType("character varying(20)")
            .HasMaxLength(20);

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

        builder.Property(t => t.FechaNacimiento)
            .HasColumnName("fecha_nacimiento")
            .HasColumnType("date");

        builder.Property(t => t.Ocupacion)
            .HasColumnName("ocupacion")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

        builder.Property(t => t.IngresosDeclarados)
            .HasColumnName("ingresos_declarados")
            .HasColumnType("numeric(12,2)");

        builder.Property(t => t.Observaciones)
            .HasColumnName("observaciones")
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
        builder.HasOne(t => t.Tenants)
            .WithMany(t => t.Inquilinos)
            .HasForeignKey(d => d.IdTenant)
            .HasConstraintName("fk_inquilinos_tenant");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "inquilinos";
    }

    public readonly struct Columns
    {
        public const string IdInquilino = "id_inquilino";
        public const string IdTenant = "id_tenant";
        public const string Nombre = "nombre";
        public const string Apellido = "apellido";
        public const string Dni = "dni";
        public const string Cuit = "cuit";
        public const string Email = "email";
        public const string Telefono = "telefono";
        public const string Direccion = "direccion";
        public const string FechaNacimiento = "fecha_nacimiento";
        public const string Ocupacion = "ocupacion";
        public const string IngresosDeclarados = "ingresos_declarados";
        public const string Observaciones = "observaciones";
        public const string Activo = "activo";
        public const string FechaCreacion = "fecha_creacion";
        public const string FechaActualizacion = "fecha_actualizacion";
        public const string Eliminado = "eliminado";
        public const string FechaEliminacion = "fecha_eliminacion";
    }
    #endregion
}
