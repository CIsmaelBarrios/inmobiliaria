using FluentMigrator;
using System.Data;

namespace inmobiliaria.Migrations
{
    [Migration(20250730_1009, "Creando tabla Garantias")]
    public class _20250730_1009_Garantias : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("garantias")
                .WithColumn("id_garantia").AsInt64().PrimaryKey().Identity()
                .WithColumn("id_tenant").AsInt64().NotNullable()
                .WithColumn("id_contrato").AsInt64().NotNullable()
                .WithColumn("tipo").AsString(50).NotNullable()
                .WithColumn("nombre_garante").AsString(200).Nullable()
                .WithColumn("dni_garante").AsString(20).Nullable()
                .WithColumn("telefono_garante").AsString(20).Nullable()
                .WithColumn("email_garante").AsString(150).Nullable()
                .WithColumn("direccion_garante").AsCustom("TEXT").Nullable()
                .WithColumn("monto_garantia").AsDecimal(12, 2).Nullable()
                .WithColumn("observaciones").AsCustom("TEXT").Nullable()
                .WithColumn("documentos").AsCustom("JSONB").NotNullable().WithDefaultValue("[]")
                .WithColumn("activo").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("fecha_creacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("eliminado").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("fecha_eliminacion").AsDateTime().Nullable();

            // Foreign Keys
            Create.ForeignKey("fk_garantias_tenant")
                .FromTable("garantias").ForeignColumn("id_tenant")
                .ToTable("tenants").PrimaryColumn("id_tenant")
                .OnDeleteOrUpdate(Rule.None);

            Create.ForeignKey("fk_garantias_contrato")
                .FromTable("garantias").ForeignColumn("id_contrato")
                .ToTable("contratos").PrimaryColumn("id_contrato")
                .OnDeleteOrUpdate(Rule.None);
        }
    }
}
