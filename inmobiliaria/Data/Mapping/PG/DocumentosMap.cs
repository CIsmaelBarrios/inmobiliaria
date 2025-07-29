using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Mapping.PG;

public partial class DocumentosMap
    : IEntityTypeConfiguration<Inmobiliaria.Data.Entities.Documentos>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inmobiliaria.Data.Entities.Documentos> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("documentos", "public");

        // key
        builder.HasKey(t => t.IdDocumento);

        // properties
        builder.Property(t => t.IdDocumento)
            .IsRequired()
            .HasColumnName("id_documento")
            .HasColumnType("uuid")
            .HasDefaultValueSql("uuid_generate_v4()");

        builder.Property(t => t.IdTenant)
            .IsRequired()
            .HasColumnName("id_tenant")
            .HasColumnType("uuid");

        builder.Property(t => t.EntidadTipo)
            .IsRequired()
            .HasColumnName("entidad_tipo")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50);

        builder.Property(t => t.EntidadId)
            .IsRequired()
            .HasColumnName("entidad_id")
            .HasColumnType("uuid");

        builder.Property(t => t.NombreArchivo)
            .IsRequired()
            .HasColumnName("nombre_archivo")
            .HasColumnType("character varying(255)")
            .HasMaxLength(255);

        builder.Property(t => t.TipoDocumento)
            .HasColumnName("tipo_documento")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

        builder.Property(t => t.RutaArchivo)
            .HasColumnName("ruta_archivo")
            .HasColumnType("text");

        builder.Property(t => t.TamañoArchivo)
            .HasColumnName("tamaño_archivo")
            .HasColumnType("bigint");

        builder.Property(t => t.MimeType)
            .HasColumnName("mime_type")
            .HasColumnType("character varying(100)")
            .HasMaxLength(100);

        builder.Property(t => t.Descripcion)
            .HasColumnName("descripcion")
            .HasColumnType("text");

        builder.Property(t => t.FechaSubida)
            .IsRequired()
            .HasColumnName("fecha_subida")
            .HasColumnType("timestamp without time zone")
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.Property(t => t.SubidoPor)
            .HasColumnName("subido_por")
            .HasColumnType("uuid");

        builder.Property(t => t.Activo)
            .IsRequired()
            .HasColumnName("activo")
            .HasColumnType("boolean")
            .HasDefaultValue(true);

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
            .WithMany(t => t.Documentos)
            .HasForeignKey(d => d.IdTenant)
            .HasConstraintName("fk_documentos_tenant");

        builder.HasOne(t => t.SubidoPorUsuarios)
            .WithMany(t => t.SubidoPorDocumentos)
            .HasForeignKey(d => d.SubidoPor)
            .HasConstraintName("fk_documentos_usuario");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "documentos";
    }

    public readonly struct Columns
    {
        public const string IdDocumento = "id_documento";
        public const string IdTenant = "id_tenant";
        public const string EntidadTipo = "entidad_tipo";
        public const string EntidadId = "entidad_id";
        public const string NombreArchivo = "nombre_archivo";
        public const string TipoDocumento = "tipo_documento";
        public const string RutaArchivo = "ruta_archivo";
        public const string TamañoArchivo = "tamaño_archivo";
        public const string MimeType = "mime_type";
        public const string Descripcion = "descripcion";
        public const string FechaSubida = "fecha_subida";
        public const string SubidoPor = "subido_por";
        public const string Activo = "activo";
        public const string Eliminado = "eliminado";
        public const string FechaEliminacion = "fecha_eliminacion";
    }
    #endregion
}
