using System;
using System.Collections.Generic;

namespace Inmobiliaria.Data.Entities;

public partial class Contratos
{
    public Contratos()
    {
        #region Generated Constructor
        Garantias = new HashSet<Garantias>();
        Pagos = new HashSet<Pagos>();
        #endregion
    }

    #region Generated Properties
    public Guid IdContrato { get; set; }

    public Guid IdTenant { get; set; }

    public Guid IdInquilino { get; set; }

    public Guid? IdPropiedad { get; set; }

    public Guid? IdUnidad { get; set; }

    public string? NumeroContrato { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public decimal MontoMensual { get; set; }

    public decimal? MontoDeposito { get; set; }

    public decimal? AjustePorcentaje { get; set; }

    public int? PeriodoAjuste { get; set; }

    public DateOnly? FechaUltimoAjuste { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string? ClausulasEspeciales { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public bool Eliminado { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<Garantias> Garantias { get; set; }

    public virtual Inquilinos Inquilinos { get; set; } = null!;

    public virtual ICollection<Pagos> Pagos { get; set; }

    public virtual Propiedades? Propiedades { get; set; }

    public virtual Tenants Tenants { get; set; } = null!;

    public virtual UnidadesFuncionales? UnidadesFuncionales { get; set; }

    #endregion

}
