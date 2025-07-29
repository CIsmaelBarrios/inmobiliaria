using System;
using System.Collections.Generic;

namespace Inmobiliaria.Data.Entities;

public partial class VUnidadesCompleta
{
    public VUnidadesCompleta()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public Guid? IdUnidad { get; set; }

    public Guid? IdTenant { get; set; }

    public Guid? IdPropiedad { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Tipo { get; set; }

    public int? Piso { get; set; }

    public string? Numero { get; set; }

    public int? Superficie { get; set; }

    public int? Ambientes { get; set; }

    public int? Dormitorios { get; set; }

    public int? Baños { get; set; }

    public string? Estado { get; set; }

    public decimal? PrecioAlquiler { get; set; }

    public decimal? PrecioVenta { get; set; }

    public decimal? Expensas { get; set; }

    public string? DireccionPropiedad { get; set; }

    public string? Ciudad { get; set; }

    public string? Provincia { get; set; }

    public string? PropietarioCompleto { get; set; }

    public string? PropietarioTelefono { get; set; }

    public string? EstadoActual { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
