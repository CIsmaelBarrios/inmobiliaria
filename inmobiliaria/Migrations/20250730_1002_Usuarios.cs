using FluentMigrator;
using Microsoft.AspNetCore.Http.HttpResults;
using System.CodeDom.Compiler;
using System.Data;

namespace inmobiliaria.Migrations
{
    [Migration(20250730_1002, "Creando tabla Usuarios")]
    public class _20250730_1002_Usuarios : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("usuarios")
                .WithColumn("id_usuario").AsInt64().PrimaryKey().Identity() // ← Auto incremental
                .WithColumn("id_tenant").AsInt64().NotNullable()            // ← Foreign key debe ser BIGINT
                .WithColumn("nombre").AsString(100).NotNullable()
                .WithColumn("apellido").AsString(100).NotNullable()
                .WithColumn("email").AsString(150).NotNullable()
                .WithColumn("telefono").AsString(20).Nullable()
                .WithColumn("password_hash").AsCustom("TEXT").NotNullable()
                .WithColumn("rol").AsString(50).NotNullable().WithDefaultValue("agente")
                .WithColumn("fecha_creacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("fecha_ultimo_acceso").AsDateTime().Nullable()
                .WithColumn("activo").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("eliminado").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("fecha_eliminacion").AsDateTime().Nullable();

            // Foreign Key (ajustada a BIGINT)
            Create.ForeignKey("fk_usuarios_tenant")
                .FromTable("usuarios").ForeignColumn("id_tenant")
                .ToTable("tenants").PrimaryColumn("id_tenant")
                .OnDeleteOrUpdate(Rule.None);

            // Unique constraint
            Create.UniqueConstraint("uk_usuarios_tenant_email")
                .OnTable("usuarios")
                .Columns("id_tenant", "email");
        }
    }
}
