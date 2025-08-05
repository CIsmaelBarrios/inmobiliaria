using FluentMigrator;
using System.Data;

namespace inmobiliaria.Migrations
{
    [Migration(20250730_1003, "Creando tabla Propietarios")]
    public class _20250730_1003_Propietarios : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("propietarios")
                .WithColumn("id_propietario").AsInt64().PrimaryKey().Identity()
                .WithColumn("id_tenant").AsInt64().NotNullable()
                .WithColumn("nombre").AsString(100).NotNullable()
                .WithColumn("apellido").AsString(100).NotNullable()
                .WithColumn("dni").AsString(20).NotNullable()
                .WithColumn("cuit").AsString(13).Nullable()
                .WithColumn("email").AsString(150).Nullable()
                .WithColumn("telefono").AsString(20).Nullable()
                .WithColumn("direccion").AsCustom("TEXT").Nullable()
                .WithColumn("fecha_nacimiento").AsDate().Nullable()
                .WithColumn("observaciones").AsCustom("TEXT").Nullable()
                .WithColumn("activo").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("fecha_creacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("fecha_actualizacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("eliminado").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("fecha_eliminacion").AsDateTime().Nullable();

            // Foreign Key
            Create.ForeignKey("fk_propietarios_tenant")
                .FromTable("propietarios").ForeignColumn("id_tenant")
                .ToTable("tenants").PrimaryColumn("id_tenant")
                .OnDeleteOrUpdate(Rule.None);

            // Unique constraint
            Create.UniqueConstraint("uk_propietarios_tenant_dni")
                .OnTable("propietarios")
                .Columns("id_tenant", "dni");
        }
    }
}
