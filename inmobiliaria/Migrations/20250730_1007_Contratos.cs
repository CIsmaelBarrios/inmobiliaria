using FluentMigrator;
using System.Data;

namespace inmobiliaria.Migrations
{
    [Migration(20250730_1007, "Creando tabla Contratos")]
    public class _2025_1007_Contratos : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("contratos")
                .WithColumn("id_contrato").AsInt64().PrimaryKey().Identity()
                .WithColumn("id_tenant").AsInt64().NotNullable()
                .WithColumn("id_inquilino").AsInt64().NotNullable()
                .WithColumn("id_propiedad").AsInt64().Nullable()
                .WithColumn("id_unidad").AsInt64().Nullable()
                .WithColumn("numero_contrato").AsString(50).Nullable()
                .WithColumn("fecha_inicio").AsDate().NotNullable()
                .WithColumn("fecha_fin").AsDate().NotNullable()
                .WithColumn("monto_mensual").AsDecimal(10, 2).NotNullable()
                .WithColumn("monto_deposito").AsDecimal(10, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("ajuste_porcentaje").AsDecimal(5, 2).NotNullable().WithDefaultValue(0.00)
                .WithColumn("periodo_ajuste").AsInt32().NotNullable().WithDefaultValue(12)
                .WithColumn("fecha_ultimo_ajuste").AsDate().Nullable()
                .WithColumn("estado").AsString(50).NotNullable().WithDefaultValue("activo")
                .WithColumn("observaciones").AsCustom("TEXT").Nullable()
                .WithColumn("clausulas_especiales").AsCustom("TEXT").Nullable()
                .WithColumn("activo").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("fecha_creacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("fecha_actualizacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("eliminado").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("fecha_eliminacion").AsDateTime().Nullable();

            // Foreign Keys
            Create.ForeignKey("fk_contratos_tenant")
                .FromTable("contratos").ForeignColumn("id_tenant")
                .ToTable("tenants").PrimaryColumn("id_tenant")
                .OnDeleteOrUpdate(Rule.None);

            Create.ForeignKey("fk_contratos_inquilino")
                .FromTable("contratos").ForeignColumn("id_inquilino")
                .ToTable("inquilinos").PrimaryColumn("id_inquilino")
                .OnDeleteOrUpdate(Rule.None);

            Create.ForeignKey("fk_contratos_propiedad")
                .FromTable("contratos").ForeignColumn("id_propiedad")
                .ToTable("propiedades").PrimaryColumn("id_propiedad")
                .OnDeleteOrUpdate(Rule.None);

            Create.ForeignKey("fk_contratos_unidad")
                .FromTable("contratos").ForeignColumn("id_unidad")
                .ToTable("unidades_funcionales").PrimaryColumn("id_unidad")
                .OnDeleteOrUpdate(Rule.None);
        }
    }
}
