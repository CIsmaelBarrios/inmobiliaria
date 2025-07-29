using System;
using System.Collections.Generic;

namespace Inmobiliaria.Data.Entities;

public partial class Documentos
{
    public Documentos()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public Guid IdDocumento { get; set; }

    public Guid IdTenant { get; set; }

    public string EntidadTipo { get; set; } = null!;

    public Guid EntidadId { get; set; }

    public string NombreArchivo { get; set; } = null!;

    public string? TipoDocumento { get; set; }

    public string? RutaArchivo { get; set; }

    public long? TamañoArchivo { get; set; }

    public string? MimeType { get; set; }

    public string? Descripcion { get; set; }

    public DateTime FechaSubida { get; set; }

    public Guid? SubidoPor { get; set; }

    public bool Activo { get; set; }

    public bool Eliminado { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Usuarios? SubidoPorUsuarios { get; set; }

    public virtual Tenants Tenants { get; set; } = null!;

    #endregion

}
