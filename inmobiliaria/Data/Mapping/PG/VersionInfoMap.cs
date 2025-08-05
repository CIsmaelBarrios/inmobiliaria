using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Mapping.PG;

public partial class VersionInfoMap
    : IEntityTypeConfiguration<Inmobiliaria.Data.Entities.VersionInfo>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inmobiliaria.Data.Entities.VersionInfo> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("VersionInfo", "public");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.Version)
            .IsRequired()
            .HasColumnName("Version")
            .HasColumnType("bigint");

        builder.Property(t => t.AppliedOn)
            .HasColumnName("AppliedOn")
            .HasColumnType("timestamp without time zone");

        builder.Property(t => t.Description)
            .HasColumnName("Description")
            .HasColumnType("character varying(1024)")
            .HasMaxLength(1024);

        // relationships
        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "VersionInfo";
    }

    public readonly struct Columns
    {
        public const string Version = "Version";
        public const string AppliedOn = "AppliedOn";
        public const string Description = "Description";
    }
    #endregion
}
