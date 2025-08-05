using FluentMigrator;
using System.Data;

namespace inmobiliaria.Migrations
{
    [Migration(20250730_1010, "Creando tabla Documentos")]
    public class _20250730_1010_Documentos : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("documentos")
                .WithColumn("id_documento").AsInt64().PrimaryKey().Identity()
                .WithColumn("id_tenant").AsInt64().NotNullable()
                .WithColumn("entidad_tipo").AsString(50).NotNullable()
                .WithColumn("entidad_id").AsInt64().NotNullable()
                .WithColumn("nombre_archivo").AsString(255).NotNullable()
                .WithColumn("tipo_documento").AsString(100).Nullable()
                .WithColumn("ruta_archivo").AsCustom("TEXT").Nullable()
                .WithColumn("tamaño_archivo").AsInt64().Nullable()
                .WithColumn("mime_type").AsString(100).Nullable()
                .WithColumn("descripcion").AsCustom("TEXT").Nullable()
                .WithColumn("fecha_subida").AsDateTime().NotNullable().WithDefaultValue(SystemMethods.CurrentDateTime)
                .WithColumn("subido_por").AsInt64().Nullable()
                .WithColumn("activo").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("eliminado").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("fecha_eliminacion").AsDateTime().Nullable();

            // Foreign Keys
            Create.ForeignKey("fk_documentos_tenant")
                .FromTable("documentos").ForeignColumn("id_tenant")
                .ToTable("tenants").PrimaryColumn("id_tenant")
                .OnDeleteOrUpdate(Rule.None);

            Create.ForeignKey("fk_documentos_usuario")
                .FromTable("documentos").ForeignColumn("subido_por")
                .ToTable("usuarios").PrimaryColumn("id_usuario")
                .OnDeleteOrUpdate(Rule.SetNull);
        }
    }
}
