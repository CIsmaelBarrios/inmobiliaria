using System;
using System.Collections.Generic;

namespace Inmobiliaria.Data.Entities;

public partial class UnidadesFuncionales
{
    public UnidadesFuncionales()
    {
        #region Generated Constructor
        Contratos = new HashSet<Contratos>();
        #endregion
    }

    #region Generated Properties
    public Guid IdUnidad { get; set; }

    public Guid IdTenant { get; set; }

    public Guid IdPropiedad { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Nombre { get; set; }

    public string Tipo { get; set; } = null!;

    public int? Piso { get; set; }

    public string? Numero { get; set; }

    public int? Superficie { get; set; }

    public int? Ambientes { get; set; }

    public int? Dormitorios { get; set; }

    public int? Baños { get; set; }

    public int? Cocheras { get; set; }

    public bool? Balcon { get; set; }

    public bool? Terraza { get; set; }

    public bool? Parrilla { get; set; }

    public string Estado { get; set; } = null!;

    public decimal? PrecioAlquiler { get; set; }

    public decimal? PrecioVenta { get; set; }

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

    public virtual Propiedades Propiedades { get; set; } = null!;

    public virtual Tenants Tenants { get; set; } = null!;

    #endregion

}
