using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Mapping.PG;

public partial class PagosMap
    : IEntityTypeConfiguration<Inmobiliaria.Data.Entities.Pagos>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inmobiliaria.Data.Entities.Pagos> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("pagos", "public");

        // key
        builder.HasKey(t => t.IdPago);

        // properties
        builder.Property(t => t.IdPago)
            .IsRequired()
            .HasColumnName("id_pago")
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

        builder.Property(t => t.NumeroRecibo)
            .HasColumnName("numero_recibo")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50);

        builder.Property(t => t.FechaPago)
            .IsRequired()
            .HasColumnName("fecha_pago")
            .HasColumnType("date");

        builder.Property(t => t.MesCorrespondiente)
            .IsRequired()
            .HasColumnName("mes_correspondiente")
            .HasColumnType("date");

        builder.Property(t => t.MontoPagado)
            .IsRequired()
            .HasColumnName("monto_pagado")
            .HasColumnType("numeric(10,2)");

        builder.Property(t => t.MontoAlquiler)
            .IsRequired()
            .HasColumnName("monto_alquiler")
            .HasColumnType("numeric(10,2)");

        builder.Property(t => t.MontoExpensas)
            .HasColumnName("monto_expensas")
            .HasColumnType("numeric(10,2)")
            .HasDefaultValueSql("0");

        builder.Property(t => t.MontoServicios)
            .HasColumnName("monto_servicios")
            .HasColumnType("numeric(10,2)")
            .HasDefaultValueSql("0");

        builder.Property(t => t.Recargos)
            .HasColumnName("recargos")
            .HasColumnType("numeric(10,2)")
            .HasDefaultValueSql("0");

        builder.Property(t => t.Descuentos)
            .HasColumnName("descuentos")
            .HasColumnType("numeric(10,2)")
            .HasDefaultValueSql("0");

        builder.Property(t => t.FormaPago)
            .IsRequired()
            .HasColumnName("forma_pago")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50);

        builder.Property(t => t.NumeroComprobante)
            .HasColumnName("numero_comprobante")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

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

        builder.Property(t => t.Eliminado)
            .IsRequired()
            .HasColumnName("eliminado")
            .HasColumnType("boolean")
            .HasDefaultValue(false);

        builder.Property(t => t.FechaEliminacion)
            .HasColumnName("fecha_eliminacion")
            .HasColumnType("timestamp without time zone");

        // relationships
        builder.HasOne(t => t.Contratos)
            .WithMany(t => t.Pagos)
            .HasForeignKey(d => d.IdContrato)
            .HasConstraintName("fk_pagos_contrato");

        builder.HasOne(t => t.Tenants)
            .WithMany(t => t.Pagos)
            .HasForeignKey(d => d.IdTenant)
            .HasConstraintName("fk_pagos_tenant");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "pagos";
    }

    public readonly struct Columns
    {
        public const string IdPago = "id_pago";
        public const string IdTenant = "id_tenant";
        public const string IdContrato = "id_contrato";
        public const string NumeroRecibo = "numero_recibo";
        public const string FechaPago = "fecha_pago";
        public const string MesCorrespondiente = "mes_correspondiente";
        public const string MontoPagado = "monto_pagado";
        public const string MontoAlquiler = "monto_alquiler";
        public const string MontoExpensas = "monto_expensas";
        public const string MontoServicios = "monto_servicios";
        public const string Recargos = "recargos";
        public const string Descuentos = "descuentos";
        public const string FormaPago = "forma_pago";
        public const string NumeroComprobante = "numero_comprobante";
        public const string Observaciones = "observaciones";
        public const string Activo = "activo";
        public const string FechaCreacion = "fecha_creacion";
        public const string Eliminado = "eliminado";
        public const string FechaEliminacion = "fecha_eliminacion";
    }
    #endregion
}
