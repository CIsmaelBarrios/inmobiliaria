using System;
using System.Collections.Generic;

namespace Inmobiliaria.Data.Entities;

public partial class Propietarios
{
    public Propietarios()
    {
        #region Generated Constructor
        Propiedades = new HashSet<Propiedades>();
        #endregion
    }

    #region Generated Properties
    public Guid IdPropietario { get; set; }

    public Guid IdTenant { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string? Cuit { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Observaciones { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public bool Eliminado { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<Propiedades> Propiedades { get; set; }

    public virtual Tenants Tenants { get; set; } = null!;

    #endregion

}
