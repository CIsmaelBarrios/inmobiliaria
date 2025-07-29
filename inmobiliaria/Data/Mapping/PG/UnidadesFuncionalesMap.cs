using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Mapping.PG;

public partial class UnidadesFuncionalesMap
    : IEntityTypeConfiguration<Inmobiliaria.Data.Entities.UnidadesFuncionales>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inmobiliaria.Data.Entities.UnidadesFuncionales> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("unidades_funcionales", "public");

        // key
        builder.HasKey(t => t.IdUnidad);

        // properties
        builder.Property(t => t.IdUnidad)
            .IsRequired()
            .HasColumnName("id_unidad")
            .HasColumnType("uuid")
            .HasDefaultValueSql("uuid_generate_v4()");

        builder.Property(t => t.IdTenant)
            .IsRequired()
            .HasColumnName("id_tenant")
            .HasColumnType("uuid");

        builder.Property(t => t.IdPropiedad)
            .IsRequired()
            .HasColumnName("id_propiedad")
            .HasColumnType("uuid");

        builder.Property(t => t.Codigo)
            .IsRequired()
            .HasColumnName("codigo")
            .HasColumnType("character varying(20)")
            .HasMaxLength(20);

        builder.Property(t => t.Nombre)
            .HasColumnName("nombre")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

        builder.Property(t => t.Tipo)
            .IsRequired()
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

        builder.Property(t => t.Cocheras)
            .HasColumnName("cocheras")
            .HasColumnType("integer")
            .HasDefaultValue(0);

        builder.Property(t => t.Balcon)
            .HasColumnName("balcon")
            .HasColumnType("boolean")
            .HasDefaultValue(false);

        builder.Property(t => t.Terraza)
            .HasColumnName("terraza")
            .HasColumnType("boolean")
            .HasDefaultValue(false);

        builder.Property(t => t.Parrilla)
            .HasColumnName("parrilla")
            .HasColumnType("boolean")
            .HasDefaultValue(false);

        builder.Property(t => t.Estado)
            .IsRequired()
            .HasColumnName("estado")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50)
            .HasDefaultValueSql("'disponible'::character varying");

        builder.Property(t => t.PrecioAlquiler)
            .HasColumnName("precio_alquiler")
            .HasColumnType("numeric(10,2)");

        builder.Property(t => t.PrecioVenta)
            .HasColumnName("precio_venta")
            .HasColumnType("numeric(12,2)");

        builder.Property(t => t.Expensas)
            .HasColumnName("expensas")
            .HasColumnType("numeric(8,2)")
            .HasDefaultValueSql("0");

        builder.Property(t => t.Descripcion)
            .HasColumnName("descripcion")
            .HasColumnType("text");

        builder.Property(t => t.Caracteristicas)
            .HasColumnName("caracteristicas")
            .HasColumnType("jsonb")
            .HasDefaultValueSql("'{}'::jsonb");

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
            .WithMany(t => t.UnidadesFuncionales)
            .HasForeignKey(d => d.IdTenant)
            .HasConstraintName("fk_unidades_tenant");

        builder.HasOne(t => t.Propiedades)
            .WithMany(t => t.UnidadesFuncionales)
            .HasForeignKey(d => d.IdPropiedad)
            .HasConstraintName("fk_unidades_propiedad");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "unidades_funcionales";
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
        public const string Cocheras = "cocheras";
        public const string Balcon = "balcon";
        public const string Terraza = "terraza";
        public const string Parrilla = "parrilla";
        public const string Estado = "estado";
        public const string PrecioAlquiler = "precio_alquiler";
        public const string PrecioVenta = "precio_venta";
        public const string Expensas = "expensas";
        public const string Descripcion = "descripcion";
        public const string Caracteristicas = "caracteristicas";
        public const string Activo = "activo";
        public const string FechaCreacion = "fecha_creacion";
        public const string FechaActualizacion = "fecha_actualizacion";
        public const string Eliminado = "eliminado";
        public const string FechaEliminacion = "fecha_eliminacion";
    }
    #endregion
}
