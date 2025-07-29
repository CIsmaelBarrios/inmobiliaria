using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Mapping.PG;

public partial class UsuariosMap
    : IEntityTypeConfiguration<Inmobiliaria.Data.Entities.Usuarios>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inmobiliaria.Data.Entities.Usuarios> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("usuarios", "public");

        // key
        builder.HasKey(t => t.IdUsuario);

        // properties
        builder.Property(t => t.IdUsuario)
            .IsRequired()
            .HasColumnName("id_usuario")
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

        builder.Property(t => t.Email)
            .IsRequired()
            .HasColumnName("email")
            .HasColumnType("character varying(150)")
            .HasMaxLength(150);

        builder.Property(t => t.Telefono)
            .HasColumnName("telefono")
            .HasColumnType("character varying(20)")
            .HasMaxLength(20);

        builder.Property(t => t.PasswordHash)
            .IsRequired()
            .HasColumnName("password_hash")
            .HasColumnType("text");

        builder.Property(t => t.Rol)
            .IsRequired()
            .HasColumnName("rol")
            .HasColumnType("character varying(50)")
            .HasMaxLength(50)
            .HasDefaultValueSql("'agente'::character varying");

        builder.Property(t => t.FechaCreacion)
            .IsRequired()
            .HasColumnName("fecha_creacion")
            .HasColumnType("timestamp without time zone")
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.Property(t => t.FechaUltimoAcceso)
            .HasColumnName("fecha_ultimo_acceso")
            .HasColumnType("timestamp without time zone");

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
            .WithMany(t => t.Usuarios)
            .HasForeignKey(d => d.IdTenant)
            .HasConstraintName("fk_usuarios_tenant");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "usuarios";
    }

    public readonly struct Columns
    {
        public const string IdUsuario = "id_usuario";
        public const string IdTenant = "id_tenant";
        public const string Nombre = "nombre";
        public const string Apellido = "apellido";
        public const string Email = "email";
        public const string Telefono = "telefono";
        public const string PasswordHash = "password_hash";
        public const string Rol = "rol";
        public const string FechaCreacion = "fecha_creacion";
        public const string FechaUltimoAcceso = "fecha_ultimo_acceso";
        public const string Activo = "activo";
        public const string Eliminado = "eliminado";
        public const string FechaEliminacion = "fecha_eliminacion";
    }
    #endregion
}
