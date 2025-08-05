using FluentMigrator;
using System.Data;

namespace inmobiliaria.Migrations
{
    [Migration(20250730_1005, "Creando tabla Propiedades")]
    public class _20250730_1005_Propiedades : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("propiedades")
                .WithColumn("id_propiedad").AsInt64().PrimaryKey().Identity()
                .WithColumn("id_tenant").AsInt64().NotNullable()
                .WithColumn("id_propietario").AsInt64().NotNullable()
                .WithColumn("nombre").AsString(200).Nullable()
                .WithColumn("direccion").AsCustom("TEXT").NotNullable()
                .WithColumn("ciudad").AsString(100).Nullable()
                .WithColumn("provincia").AsString(100).Nullable()
                .WithColumn("codigo_postal").AsString(10).Nullable()
                .WithColumn("tipo").AsString(50).NotNullable()
                .WithColumn("superficie_total").AsInt32().Nullable()
                .WithColumn("superficie_cubierta").AsInt32().Nullable()
                .WithColumn("año_construccion").AsInt32().Nullable()
                .WithColumn("estado").AsString(50).NotNullable().WithDefaultValue("disponible")
                .WithColumn("precio_base").AsDecimal(12, 2).Nullable()
                .WithColumn("expensas").AsDecimal(10, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("descripcion").AsCustom("TEXT").Nullable()
                .WithColumn("caracteristicas").AsCustom("JSONB").NotNullable().WithDefaultValue("{}")
                .WithColumn("activo").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("fecha_creacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("fecha_actualizacion").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("eliminado").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("fecha_eliminacion").AsDateTime().Nullable();

            // Foreign Keys
            Create.ForeignKey("fk_propiedades_tenant")
                .FromTable("propiedades").ForeignColumn("id_tenant")
                .ToTable("tenants").PrimaryColumn("id_tenant")
                .OnDeleteOrUpdate(Rule.None);

            Create.ForeignKey("fk_propiedades_propietario")
                .FromTable("propiedades").ForeignColumn("id_propietario")
                .ToTable("propietarios").PrimaryColumn("id_propietario")
                .OnDeleteOrUpdate(Rule.None);
        }
    }
}
