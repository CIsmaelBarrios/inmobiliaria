using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Mapping.PG;

public partial class ContratosMap
    : IEntityTypeConfiguration<Inmobiliaria.Data.Entities.Contratos>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inmobiliaria.Data.Entities.Contratos> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("contratos", "public");

        // key
        builder.HasKey(t => t.IdContrato);

        // properties
        builder.Property(t => t.IdContrato)
            .IsRequired()
            .HasColumnName("id_contrato")
            .HasColumnType("uuid")
            .HasDefaultValueSql("uuid_generate_v4()");

        builder.Property(t => t.IdTenant)
            .IsRequired()
            .HasColumnName("id_tenant")
            .HasColumnType("uuid");

        builder.Property(t => t.IdInquilino)
            .IsRequired()
            .HasColumnName("id_inquilino")
            .HasColumnType("uuid");

        builder.Property(t => t.IdPropiedad)
            .HasColumnName("id_propiedad")
            .HasColumnType("uuid");

        builder.Property(t => t.IdUnidad)
            .HasColumnName("id_unidad")
            .HasColumnType("uuid");

        builder.Property(t => t.NumeroContrato)
            .HasColumnName("numero_contrato")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50);

        builder.Property(t => t.FechaInicio)
            .IsRequired()
            .HasColumnName("fecha_inicio")
            .HasColumnType("date");

        builder.Property(t => t.FechaFin)
            .IsRequired()
            .HasColumnName("fecha_fin")
            .HasColumnType("date");

        builder.Property(t => t.MontoMensual)
            .IsRequired()
            .HasColumnName("monto_mensual")
            .HasColumnType("numeric(10,2)");

        builder.Property(t => t.MontoDeposito)
            .HasColumnName("monto_deposito")
            .HasColumnType("numeric(10,2)")
            .HasDefaultValueSql("0");

        builder.Property(t => t.AjustePorcentaje)
            .HasColumnName("ajuste_porcentaje")
            .HasColumnType("numeric(5,2)")
            .HasDefaultValueSql("0.00");

        builder.Property(t => t.PeriodoAjuste)
            .HasColumnName("periodo_ajuste")
            .HasColumnType("integer")
            .HasDefaultValue(12);

        builder.Property(t => t.FechaUltimoAjuste)
            .HasColumnName("fecha_ultimo_ajuste")
            .HasColumnType("date");

        builder.Property(t => t.Estado)
            .IsRequired()
            .HasColumnName("estado")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50)
            .HasDefaultValueSql("'activo'::character varying");

        builder.Property(t => t.Observaciones)
            .HasColumnName("observaciones")
            .HasColumnType("text");

        builder.Property(t => t.ClausulasEspeciales)
            .HasColumnName("clausulas_especiales")
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
            .WithMany(t => t.Contratos)
            .HasForeignKey(d => d.IdTenant)
            .HasConstraintName("fk_contratos_tenant");

        builder.HasOne(t => t.Inquilinos)
            .WithMany(t => t.Contratos)
            .HasForeignKey(d => d.IdInquilino)
            .HasConstraintName("fk_contratos_inquilino");

        builder.HasOne(t => t.Propiedades)
            .WithMany(t => t.Contratos)
            .HasForeignKey(d => d.IdPropiedad)
            .HasConstraintName("fk_contratos_propiedad");

        builder.HasOne(t => t.UnidadesFuncionales)
            .WithMany(t => t.Contratos)
            .HasForeignKey(d => d.IdUnidad)
            .HasConstraintName("fk_contratos_unidad");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "contratos";
    }

    public readonly struct Columns
    {
        public const string IdContrato = "id_contrato";
        public const string IdTenant = "id_tenant";
        public const string IdInquilino = "id_inquilino";
        public const string IdPropiedad = "id_propiedad";
        public const string IdUnidad = "id_unidad";
        public const string NumeroContrato = "numero_contrato";
        public const string FechaInicio = "fecha_inicio";
        public const string FechaFin = "fecha_fin";
        public const string MontoMensual = "monto_mensual";
        public const string MontoDeposito = "monto_deposito";
        public const string AjustePorcentaje = "ajuste_porcentaje";
        public const string PeriodoAjuste = "periodo_ajuste";
        public const string FechaUltimoAjuste = "fecha_ultimo_ajuste";
        public const string Estado = "estado";
        public const string Observaciones = "observaciones";
        public const string ClausulasEspeciales = "clausulas_especiales";
        public const string Activo = "activo";
        public const string FechaCreacion = "fecha_creacion";
        public const string FechaActualizacion = "fecha_actualizacion";
        public const string Eliminado = "eliminado";
        public const string FechaEliminacion = "fecha_eliminacion";
    }
    #endregion
}
