using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Mapping.PG;

public partial class GarantiasMap
    : IEntityTypeConfiguration<Inmobiliaria.Data.Entities.Garantias>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inmobiliaria.Data.Entities.Garantias> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("garantias", "public");

        // key
        builder.HasKey(t => t.IdGarantia);

        // properties
        builder.Property(t => t.IdGarantia)
            .IsRequired()
            .HasColumnName("id_garantia")
            .HasColumnType("uuid")
            .HasDefaultValueSql("uuid_generate_v4()");

        builder.Property(t => t.IdTenant)
            .IsRequired()
            .HasColumnName("id_tenant")
            .HasColumnType("uuid");

        builder.Property(t => t.IdContrato)
            .IsRequired()
            .HasColumnName("id_contrato")
            .HasColumnType("uuid");

        builder.Property(t => t.Tipo)
            .IsRequired()
            .HasColumnName("tipo")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50);

        builder.Property(t => t.NombreGarante)
            .HasColumnName("nombre_garante")
            .HasColumnType("character varying(200)")
            .HasMaxLength(200);

        builder.Property(t => t.DniGarante)
            .HasColumnName("dni_garante")
            .HasColumnType("character varying(20)")
            .HasMaxLength(20);

        builder.Property(t => t.TelefonoGarante)
            .HasColumnName("telefono_garante")
            .HasColumnType("character varying(20)")
            .HasMaxLength(20);

        builder.Property(t => t.EmailGarante)
            .HasColumnName("email_garante")
            .HasColumnType("character varying(150)")
            .HasMaxLength(150);

        builder.Property(t => t.DireccionGarante)
            .HasColumnName("direccion_garante")
            .HasColumnType("text");

        builder.Property(t => t.MontoGarantia)
            .HasColumnName("monto_garantia")
            .HasColumnType("numeric(12,2)");

        builder.Property(t => t.Observaciones)
            .HasColumnName("observaciones")
            .HasColumnType("text");

        builder.Property(t => t.Documentos)
            .HasColumnName("documentos")
            .HasColumnType("jsonb")
            .HasDefaultValueSql("'[]'::jsonb");

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
            .WithMany(t => t.Garantias)
            .HasForeignKey(d => d.IdTenant)
            .HasConstraintName("fk_garantias_tenant");

        builder.HasOne(t => t.Contratos)
            .WithMany(t => t.Garantias)
            .HasForeignKey(d => d.IdContrato)
            .HasConstraintName("fk_garantias_contrato");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "garantias";
    }

    public readonly struct Columns
    {
        public const string IdGarantia = "id_garantia";
        public const string IdTenant = "id_tenant";
        public const string IdContrato = "id_contrato";
        public const string Tipo = "tipo";
        public const string NombreGarante = "nombre_garante";
        public const string DniGarante = "dni_garante";
        public const string TelefonoGarante = "telefono_garante";
        public const string EmailGarante = "email_garante";
        public const string DireccionGarante = "direccion_garante";
        public const string MontoGarantia = "monto_garantia";
        public const string Observaciones = "observaciones";
        public const string Documentos = "documentos";
        public const string Activo = "activo";
        public const string FechaCreacion = "fecha_creacion";
        public const string Eliminado = "eliminado";
        public const string FechaEliminacion = "fecha_eliminacion";
    }
    #endregion
}
