using FluentMigrator;
using Microsoft.AspNetCore.Http.HttpResults;
using System.CodeDom.Compiler;

namespace inmobiliaria.Migrations
{
    [Migration(20250730_1001, "Creando Tabla Tenants")]
    public class _20250730_1001_Tenants : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("tenants")
                .WithColumn("id_tenant").AsInt64().PrimaryKey().Identity() // ← ahora es auto incremental
                .WithColumn("nombre").AsString(100).NotNullable()
                .WithColumn("cuit").AsString(13).Nullable()
                .WithColumn("email").AsString(150).Nullable()
                .WithColumn("telefono").AsString(20).Nullable()
                .WithColumn("direccion").AsCustom("TEXT").Nullable()
                .WithColumn("activo").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("fecha_creacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("fecha_actualizacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("eliminado").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("fecha_eliminacion").AsDateTime().Nullable();
        }
    }
}
