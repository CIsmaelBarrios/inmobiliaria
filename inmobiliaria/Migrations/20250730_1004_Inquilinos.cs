using FluentMigrator;
using System.Data;

namespace inmobiliaria.Migrations
{
    [Migration(20250730_1004, "Creando tabla Inquilinos")]
    public class _20250730_1004_Inquilinos : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("inquilinos")
                .WithColumn("id_inquilino").AsInt64().PrimaryKey().Identity()
                .WithColumn("id_tenant").AsInt64().NotNullable()
                .WithColumn("nombre").AsString(100).NotNullable()
                .WithColumn("apellido").AsString(100).NotNullable()
                .WithColumn("dni").AsString(20).NotNullable()
                .WithColumn("cuit").AsString(13).Nullable()
                .WithColumn("email").AsString(150).Nullable()
                .WithColumn("telefono").AsString(20).Nullable()
                .WithColumn("direccion").AsCustom("TEXT").Nullable()
                .WithColumn("fecha_nacimiento").AsDate().Nullable()
                .WithColumn("ocupacion").AsString(100).Nullable()
                .WithColumn("ingresos_declarados").AsDecimal(12, 2).Nullable()
                .WithColumn("observaciones").AsCustom("TEXT").Nullable()
                .WithColumn("activo").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("fecha_creacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("fecha_actualizacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("eliminado").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("fecha_eliminacion").AsDateTime().Nullable();

            // Foreign Key
            Create.ForeignKey("fk_inquilinos_tenant")
                .FromTable("inquilinos").ForeignColumn("id_tenant")
                .ToTable("tenants").PrimaryColumn("id_tenant")
                .OnDeleteOrUpdate(Rule.None);

            // Unique constraint
            Create.UniqueConstraint("uk_inquilinos_tenant_dni")
                .OnTable("inquilinos")
                .Columns("id_tenant", "dni");
        }
    }
}
