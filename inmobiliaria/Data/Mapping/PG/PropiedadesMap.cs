using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Mapping.PG;

public partial class PropiedadesMap
    : IEntityTypeConfiguration<Inmobiliaria.Data.Entities.Propiedades>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inmobiliaria.Data.Entities.Propiedades> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("propiedades", "public");

        // key
        builder.HasKey(t => t.IdPropiedad);

        // properties
        builder.Property(t => t.IdPropiedad)
            .IsRequired()
            .HasColumnName("id_propiedad")
            .HasColumnType("uuid")
            .HasDefaultValueSql("uuid_generate_v4()");

        builder.Property(t => t.IdTenant)
            .IsRequired()
            .HasColumnName("id_tenant")
            .HasColumnType("uuid");

        builder.Property(t => t.IdPropietario)
            .IsRequired()
            .HasColumnName("id_propietario")
            .HasColumnType("uuid");

        builder.Property(t => t.Nombre)
            .HasColumnName("nombre")
            .HasColumnType("character varying(200)")
            .HasMaxLength(200);

        builder.Property(t => t.Direccion)
            .IsRequired()
            .HasColumnName("direccion")
            .HasColumnType("text");

        builder.Property(t => t.Ciudad)
            .HasColumnName("ciudad")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

        builder.Property(t => t.Provincia)
            .HasColumnName("provincia")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

        builder.Property(t => t.CodigoPostal)
            .HasColumnName("codigo_postal")
            .HasColumnType("character varying(10)")
            .HasMaxLength(10);

        builder.Property(t => t.Tipo)
            .IsRequired()
            .HasColumnName("tipo")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50);

        builder.Property(t => t.SuperficieTotal)
            .HasColumnName("superficie_total")
            .HasColumnType("integer");

        builder.Property(t => t.SuperficieCubierta)
            .HasColumnName("superficie_cubierta")
            .HasColumnType("integer");

        builder.Property(t => t.AñoConstruccion)
            .HasColumnName("año_construccion")
            .HasColumnType("integer");

        builder.Property(t => t.Estado)
            .IsRequired()
            .HasColumnName("estado")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50)
            .HasDefaultValueSql("'disponible'::character varying");

        builder.Property(t => t.PrecioBase)
            .HasColumnName("precio_base")
            .HasColumnType("numeric(12,2)");

        builder.Property(t => t.Expensas)
            .HasColumnName("expensas")
            .HasColumnType("numeric(10,2)")
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
            .WithMany(t => t.Propiedades)
            .HasForeignKey(d => d.IdTenant)
            .HasConstraintName("fk_propiedades_tenant");

        builder.HasOne(t => t.Propietarios)
            .WithMany(t => t.Propiedades)
            .HasForeignKey(d => d.IdPropietario)
            .HasConstraintName("fk_propiedades_propietario");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "propiedades";
    }

    public readonly struct Columns
    {
        public const string IdPropiedad = "id_propiedad";
        public const string IdTenant = "id_tenant";
        public const string IdPropietario = "id_propietario";
        public const string Nombre = "nombre";
        public const string Direccion = "direccion";
        public const string Ciudad = "ciudad";
        public const string Provincia = "provincia";
        public const string CodigoPostal = "codigo_postal";
        public const string Tipo = "tipo";
        public const string SuperficieTotal = "superficie_total";
        public const string SuperficieCubierta = "superficie_cubierta";
        public const string AñoConstruccion = "año_construccion";
        public const string Estado = "estado";
        public const string PrecioBase = "precio_base";
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
