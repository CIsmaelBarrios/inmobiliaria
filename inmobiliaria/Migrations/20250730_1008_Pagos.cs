using FluentMigrator;
using System.Data;

namespace inmobiliaria.Migrations
{
    [Migration(20250730_1008, "Creando tabla Pagos")]
    public class _20250730_1008_Pagos : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("pagos")
                .WithColumn("id_pago").AsInt64().PrimaryKey().Identity()
                .WithColumn("id_tenant").AsInt64().NotNullable()
                .WithColumn("id_contrato").AsInt64().NotNullable()
                .WithColumn("numero_recibo").AsString(50).Nullable()
                .WithColumn("fecha_pago").AsDate().NotNullable()
                .WithColumn("mes_correspondiente").AsDate().NotNullable()
                .WithColumn("monto_pagado").AsDecimal(10, 2).NotNullable()
                .WithColumn("monto_alquiler").AsDecimal(10, 2).NotNullable()
                .WithColumn("monto_expensas").AsDecimal(10, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("monto_servicios").AsDecimal(10, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("recargos").AsDecimal(10, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("descuentos").AsDecimal(10, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("forma_pago").AsString(50).NotNullable()
                .WithColumn("numero_comprobante").AsString(100).Nullable()
                .WithColumn("observaciones").AsCustom("TEXT").Nullable()
                .WithColumn("activo").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("fecha_creacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("eliminado").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("fecha_eliminacion").AsDateTime().Nullable();

            // Foreign Keys
            Create.ForeignKey("fk_pagos_tenant")
                .FromTable("pagos").ForeignColumn("id_tenant")
                .ToTable("tenants").PrimaryColumn("id_tenant")
                .OnDeleteOrUpdate(Rule.None);

            Create.ForeignKey("fk_pagos_contrato")
                .FromTable("pagos").ForeignColumn("id_contrato")
                .ToTable("contratos").PrimaryColumn("id_contrato")
                .OnDeleteOrUpdate(Rule.None);
        }
    }
}
