using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Mapping.PG;

public partial class VContratosActivosMap
    : IEntityTypeConfiguration<Inmobiliaria.Data.Entities.VContratosActivos>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inmobiliaria.Data.Entities.VContratosActivos> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("v_contratos_activos", "public");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.IdContrato)
            .HasColumnName("id_contrato")
            .HasColumnType("uuid");

        builder.Property(t => t.IdTenant)
            .HasColumnName("id_tenant")
            .HasColumnType("uuid");

        builder.Property(t => t.NumeroContrato)
            .HasColumnName("numero_contrato")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50);

        builder.Property(t => t.FechaInicio)
            .HasColumnName("fecha_inicio")
            .HasColumnType("date");

        builder.Property(t => t.FechaFin)
            .HasColumnName("fecha_fin")
            .HasColumnType("date");

        builder.Property(t => t.MontoMensual)
            .HasColumnName("monto_mensual")
            .HasColumnType("numeric(10,2)");

        builder.Property(t => t.Estado)
            .HasColumnName("estado")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50);

        builder.Property(t => t.InquilinoCompleto)
            .HasColumnName("inquilino_completo")
            .HasColumnType("text");

        builder.Property(t => t.InquilinoDni)
            .HasColumnName("inquilino_dni")
            .HasColumnType("character varying(20)")
            .HasMaxLength(20);

        builder.Property(t => t.InquilinoTelefono)
            .HasColumnName("inquilino_telefono")
            .HasColumnType("character varying(20)")
            .HasMaxLength(20);

        builder.Property(t => t.PropiedadReferencia)
            .HasColumnName("propiedad_referencia")
            .HasColumnType("character varying");

        builder.Property(t => t.Superficie)
            .HasColumnName("superficie")
            .HasColumnType("integer");

        builder.Property(t => t.PropietarioCompleto)
            .HasColumnName("propietario_completo")
            .HasColumnType("text");

        // relationships
        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "v_contratos_activos";
    }

    public readonly struct Columns
    {
        public const string IdContrato = "id_contrato";
        public const string IdTenant = "id_tenant";
        public const string NumeroContrato = "numero_contrato";
        public const string FechaInicio = "fecha_inicio";
        public const string FechaFin = "fecha_fin";
        public const string MontoMensual = "monto_mensual";
        public const string Estado = "estado";
        public const string InquilinoCompleto = "inquilino_completo";
        public const string InquilinoDni = "inquilino_dni";
        public const string InquilinoTelefono = "inquilino_telefono";
        public const string PropiedadReferencia = "propiedad_referencia";
        public const string Superficie = "superficie";
        public const string PropietarioCompleto = "propietario_completo";
    }
    #endregion
}
