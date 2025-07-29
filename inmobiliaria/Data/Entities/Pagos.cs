using System;
using System.Collections.Generic;

namespace Inmobiliaria.Data.Entities;

public partial class Pagos
{
    public Pagos()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public Guid IdPago { get; set; }

    public Guid IdTenant { get; set; }

    public Guid IdContrato { get; set; }

    public string? NumeroRecibo { get; set; }

    public DateOnly FechaPago { get; set; }

    public DateOnly MesCorrespondiente { get; set; }

    public decimal MontoPagado { get; set; }

    public decimal MontoAlquiler { get; set; }

    public decimal? MontoExpensas { get; set; }

    public decimal? MontoServicios { get; set; }

    public decimal? Recargos { get; set; }

    public decimal? Descuentos { get; set; }

    public string FormaPago { get; set; } = null!;

    public string? NumeroComprobante { get; set; }

    public string? Observaciones { get; set; }

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
