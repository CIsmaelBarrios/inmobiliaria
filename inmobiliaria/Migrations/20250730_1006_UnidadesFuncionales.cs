using FluentMigrator;
using System.Data;

namespace inmobiliaria.Migrations
{
    [Migration(20250730_1006, "Creando tabla Unidades Funcionales")]
    public class _20250730_1006_UnidadesFuncionales : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("unidades_funcionales")
                .WithColumn("id_unidad").AsInt64().PrimaryKey().Identity()
                .WithColumn("id_tenant").AsInt64().NotNullable()
                .WithColumn("id_propiedad").AsInt64().NotNullable()
                .WithColumn("codigo").AsString(20).NotNullable()
                .WithColumn("nombre").AsString(100).Nullable()
                .WithColumn("tipo").AsString(50).NotNullable()
                .WithColumn("piso").AsInt32().Nullable()
                .WithColumn("numero").AsString(10).Nullable()
                .WithColumn("superficie").AsInt32().Nullable()
                .WithColumn("ambientes").AsInt32().Nullable()
                .WithColumn("dormitorios").AsInt32().Nullable()
                .WithColumn("baños").AsInt32().Nullable()
                .WithColumn("cocheras").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("balcon").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("terraza").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("parrilla").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("estado").AsString(50).NotNullable().WithDefaultValue("disponible")
                .WithColumn("precio_alquiler").AsDecimal(10, 2).Nullable()
                .WithColumn("precio_venta").AsDecimal(12, 2).Nullable()
                .WithColumn("expensas").AsDecimal(8, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("descripcion").AsCustom("TEXT").Nullable()
                .WithColumn("caracteristicas").AsCustom("JSONB").NotNullable().WithDefaultValue("{}")
                .WithColumn("activo").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("fecha_creacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("fecha_actualizacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("eliminado").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("fecha_eliminacion").AsDateTime().Nullable();

            // Foreign Keys
            Create.ForeignKey("fk_unidades_tenant")
                .FromTable("unidades_funcionales").ForeignColumn("id_tenant")
                .ToTable("tenants").PrimaryColumn("id_tenant")
                .OnDeleteOrUpdate(Rule.None);

            Create.ForeignKey("fk_unidades_propiedad")
                .FromTable("unidades_funcionales").ForeignColumn("id_propiedad")
                .ToTable("propiedades").PrimaryColumn("id_propiedad")
                .OnDeleteOrUpdate(Rule.None);

            // Unique constraint
            Create.UniqueConstraint("uk_unidades_tenant_propiedad_codigo")
                .OnTable("unidades_funcionales")
                .Columns("id_tenant", "id_propiedad", "codigo");
        }
    }
}
