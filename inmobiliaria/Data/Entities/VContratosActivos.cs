using System;
using System.Collections.Generic;

namespace Inmobiliaria.Data.Entities;

public partial class VContratosActivos
{
    public VContratosActivos()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public Guid? IdContrato { get; set; }

    public Guid? IdTenant { get; set; }

    public string? NumeroContrato { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public decimal? MontoMensual { get; set; }

    public string? Estado { get; set; }

    public string? InquilinoCompleto { get; set; }

    public string? InquilinoDni { get; set; }

    public string? InquilinoTelefono { get; set; }

    public string? PropiedadReferencia { get; set; }

    public int? Superficie { get; set; }

    public string? PropietarioCompleto { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
