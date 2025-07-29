using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Mapping.PG;

public partial class VUnidadesCompletaMap
    : IEntityTypeConfiguration<Inmobiliaria.Data.Entities.VUnidadesCompleta>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inmobiliaria.Data.Entities.VUnidadesCompleta> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("v_unidades_completa", "public");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.IdUnidad)
            .HasColumnName("id_unidad")
            .HasColumnType("uuid");

        builder.Property(t => t.IdTenant)
            .HasColumnName("id_tenant")
            .HasColumnType("uuid");

        builder.Property(t => t.IdPropiedad)
            .HasColumnName("id_propiedad")
            .HasColumnType("uuid");

        builder.Property(t => t.Codigo)
            .HasColumnName("codigo")
            .HasColumnType("character varying(20)")
            .HasMaxLength(20);

        builder.Property(t => t.Nombre)
            .HasColumnName("nombre")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

        builder.Property(t => t.Tipo)
            .HasColumnName("tipo")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50);

        builder.Property(t => t.Piso)
            .HasColumnName("piso")
            .HasColumnType("integer");

        builder.Property(t => t.Numero)
            .HasColumnName("numero")
            .HasColumnType("character varying(10)")
            .HasMaxLength(10);

        builder.Property(t => t.Superficie)
            .HasColumnName("superficie")
            .HasColumnType("integer");

        builder.Property(t => t.Ambientes)
            .HasColumnName("ambientes")
            .HasColumnType("integer");

        builder.Property(t => t.Dormitorios)
            .HasColumnName("dormitorios")
            .HasColumnType("integer");

        builder.Property(t => t.Baños)
            .HasColumnName("baños")
            .HasColumnType("integer");

        builder.Property(t => t.Estado)
            .HasColumnName("estado")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50);

        builder.Property(t => t.PrecioAlquiler)
            .HasColumnName("precio_alquiler")
            .HasColumnType("numeric(10,2)");

        builder.Property(t => t.PrecioVenta)
            .HasColumnName("precio_venta")
            .HasColumnType("numeric(12,2)");

        builder.Property(t => t.Expensas)
            .HasColumnName("expensas")
            .HasColumnType("numeric(8,2)");

        builder.Property(t => t.DireccionPropiedad)
            .HasColumnName("direccion_propiedad")
            .HasColumnType("text");

        builder.Property(t => t.Ciudad)
            .HasColumnName("ciudad")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

        builder.Property(t => t.Provincia)
            .HasColumnName("provincia")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

        builder.Property(t => t.PropietarioCompleto)
            .HasColumnName("propietario_completo")
            .HasColumnType("text");

        builder.Property(t => t.PropietarioTelefono)
            .HasColumnName("propietario_telefono")
            .HasColumnType("character varying(20)")
            .HasMaxLength(20);

        builder.Property(t => t.EstadoActual)
            .HasColumnName("estado_actual")
            .HasColumnType("character varying");

        // relationships
        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "v_unidades_completa";
    }

    public readonly struct Columns
    {
        public const string IdUnidad = "id_unidad";
        public const string IdTenant = "id_tenant";
        public const string IdPropiedad = "id_propiedad";
        public const string Codigo = "codigo";
        public const string Nombre = "nombre";
        public const string Tipo = "tipo";
        public const string Piso = "piso";
        public const string Numero = "numero";
        public const string Superficie = "superficie";
        public const string Ambientes = "ambientes";
        public const string Dormitorios = "dormitorios";
        public const string Baños = "baños";
        public const string Estado = "estado";
        public const string PrecioAlquiler = "precio_alquiler";
        public const string PrecioVenta = "precio_venta";
        public const string Expensas = "expensas";
        public const string DireccionPropiedad = "direccion_propiedad";
        public const string Ciudad = "ciudad";
        public const string Provincia = "provincia";
        public const string PropietarioCompleto = "propietario_completo";
        public const string PropietarioTelefono = "propietario_telefono";
        public const string EstadoActual = "estado_actual";
    }
    #endregion
}
