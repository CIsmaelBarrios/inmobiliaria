using System;
using System.Collections.Generic;

namespace Inmobiliaria.Data.Entities;

public partial class Propiedades
{
    public Propiedades()
    {
        #region Generated Constructor
        Contratos = new HashSet<Contratos>();
        UnidadesFuncionales = new HashSet<UnidadesFuncionales>();
        #endregion
    }

    #region Generated Properties
    public Guid IdPropiedad { get; set; }

    public Guid IdTenant { get; set; }

    public Guid IdPropietario { get; set; }

    public string? Nombre { get; set; }

    public string Direccion { get; set; } = null!;

    public string? Ciudad { get; set; }

    public string? Provincia { get; set; }

    public string? CodigoPostal { get; set; }

    public string Tipo { get; set; } = null!;

    public int? SuperficieTotal { get; set; }

    public int? SuperficieCubierta { get; set; }

    public int? AñoConstruccion { get; set; }

    public string Estado { get; set; } = null!;

    public decimal? PrecioBase { get; set; }

    public decimal? Expensas { get; set; }

    public string? Descripcion { get; set; }

    public string? Caracteristicas { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public bool Eliminado { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<Contratos> Contratos { get; set; }

    public virtual Propietarios Propietarios { get; set; } = null!;

    public virtual Tenants Tenants { get; set; } = null!;

    public virtual ICollection<UnidadesFuncionales> UnidadesFuncionales { get; set; }

    #endregion

}
