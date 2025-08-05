using FluentMigrator;

namespace inmobiliaria.Migrations
{
    [Migration(20250730_1012, "Creando índices para optimización")]
    public class _20250730_1012_CrearIndices : AutoReversingMigration
    {
        public override void Up()
        {
            // Índices para Tenants
            Create.Index("idx_tenants_activo").OnTable("tenants").OnColumn("activo").Ascending();

            // Índices para Usuarios
            Create.Index("idx_usuarios_tenant").OnTable("usuarios").OnColumn("id_tenant").Ascending();
            Create.Index("idx_usuarios_email").OnTable("usuarios").OnColumn("email").Ascending();
            Create.Index("idx_usuarios_rol").OnTable("usuarios").OnColumn("rol").Ascending();

            // Índices para Propietarios
            Create.Index("idx_propietarios_tenant").OnTable("propietarios").OnColumn("id_tenant").Ascending();
            Create.Index("idx_propietarios_dni").OnTable("propietarios").OnColumn("dni").Ascending();

            // Índices para Inquilinos
            Create.Index("idx_inquilinos_tenant").OnTable("inquilinos").OnColumn("id_tenant").Ascending();
            Create.Index("idx_inquilinos_dni").OnTable("inquilinos").OnColumn("dni").Ascending();

            // Índices para Propiedades
            Create.Index("idx_propiedades_tenant").OnTable("propiedades").OnColumn("id_tenant").Ascending();
            Create.Index("idx_propiedades_propietario").OnTable("propiedades").OnColumn("id_propietario").Ascending();
            Create.Index("idx_propiedades_estado").OnTable("propiedades").OnColumn("estado").Ascending();
            Create.Index("idx_propiedades_tipo").OnTable("propiedades").OnColumn("tipo").Ascending();
            Create.Index("idx_propiedades_ciudad").OnTable("propiedades").OnColumn("ciudad").Ascending();

            // Índices para Unidades Funcionales
            Create.Index("idx_unidades_tenant").OnTable("unidades_funcionales").OnColumn("id_tenant").Ascending();
            Create.Index("idx_unidades_propiedad").OnTable("unidades_funcionales").OnColumn("id_propiedad").Ascending();
            Create.Index("idx_unidades_estado").OnTable("unidades_funcionales").OnColumn("estado").Ascending();
            Create.Index("idx_unidades_tipo").OnTable("unidades_funcionales").OnColumn("tipo").Ascending();

            // Índices para Contratos
            Create.Index("idx_contratos_tenant").OnTable("contratos").OnColumn("id_tenant").Ascending();
            Create.Index("idx_contratos_inquilino").OnTable("contratos").OnColumn("id_inquilino").Ascending();
            Create.Index("idx_contratos_estado").OnTable("contratos").OnColumn("estado").Ascending();

            // Índices para Pagos
            Create.Index("idx_pagos_tenant").OnTable("pagos").OnColumn("id_tenant").Ascending();
            Create.Index("idx_pagos_contrato").OnTable("pagos").OnColumn("id_contrato").Ascending();
            Create.Index("idx_pagos_fecha").OnTable("pagos").OnColumn("fecha_pago").Descending();

            // Índices para Garantías
            Create.Index("idx_garantias_tenant").OnTable("garantias").OnColumn("id_tenant").Ascending();
            Create.Index("idx_garantias_contrato").OnTable("garantias").OnColumn("id_contrato").Ascending();
            Create.Index("idx_garantias_tipo").OnTable("garantias").OnColumn("tipo").Ascending();

            // Índices para Documentos
            Create.Index("idx_documentos_tenant").OnTable("documentos").OnColumn("id_tenant").Ascending();
            Create.Index("idx_documentos_entidad").OnTable("documentos").OnColumn("entidad_tipo").Ascending();
            Create.Index("idx_documentos_fecha").OnTable("documentos").OnColumn("fecha_subida").Descending();
        }
    }
}
