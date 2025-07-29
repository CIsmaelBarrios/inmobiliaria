using System;
using System.Collections.Generic;

namespace Inmobiliaria.Data.Entities;

public partial class Usuarios
{
    public Usuarios()
    {
        #region Generated Constructor
        SubidoPorDocumentos = new HashSet<Documentos>();
        #endregion
    }

    #region Generated Properties
    public Guid IdUsuario { get; set; }

    public Guid IdTenant { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Telefono { get; set; }

    public string PasswordHash { get; set; } = null!;

    public string Rol { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaUltimoAcceso { get; set; }

    public bool Activo { get; set; }

    public bool Eliminado { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<Documentos> SubidoPorDocumentos { get; set; }

    public virtual Tenants Tenants { get; set; } = null!;

    #endregion

}
