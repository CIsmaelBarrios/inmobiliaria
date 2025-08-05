using System;
using System.Collections.Generic;

namespace Inmobiliaria.Data.Entities;

public partial class Garantias
{
    public Garantias()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public long IdGarantia { get; set; }

    public long IdTenant { get; set; }

    public long IdContrato { get; set; }

    public string Tipo { get; set; } = null!;

    public string? NombreGarante { get; set; }

    public string? DniGarante { get; set; }

    public string? TelefonoGarante { get; set; }

    public string? EmailGarante { get; set; }

    public string? DireccionGarante { get; set; }

    public decimal? MontoGarantia { get; set; }

    public string? Observaciones { get; set; }

    public string Documentos { get; set; } = null!;

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Eliminado { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Contratos Contratos { get; set; } = null!;

    public virtual Tenants Tenants { get; set; } = null!;

    #endregion

}
