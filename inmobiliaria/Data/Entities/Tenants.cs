using System;
using System.Collections.Generic;

namespace Inmobiliaria.Data.Entities;

public partial class Tenants
{
    public Tenants()
    {
        #region Generated Constructor
        Contratos = new HashSet<Contratos>();
        Documentos = new HashSet<Documentos>();
        Garantias = new HashSet<Garantias>();
        Inquilinos = new HashSet<Inquilinos>();
        Pagos = new HashSet<Pagos>();
        Propiedades = new HashSet<Propiedades>();
        Propietarios = new HashSet<Propietarios>();
        UnidadesFuncionales = new HashSet<UnidadesFuncionales>();
        Usuarios = new HashSet<Usuarios>();
        #endregion
    }

    #region Generated Properties
    public Guid IdTenant { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Cuit { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public bool Eliminado { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<Contratos> Contratos { get; set; }

    public virtual ICollection<Documentos> Documentos { get; set; }

    public virtual ICollection<Garantias> Garantias { get; set; }

    public virtual ICollection<Inquilinos> Inquilinos { get; set; }

    public virtual ICollection<Pagos> Pagos { get; set; }

    public virtual ICollection<Propiedades> Propiedades { get; set; }

    public virtual ICollection<Propietarios> Propietarios { get; set; }

    public virtual ICollection<UnidadesFuncionales> UnidadesFuncionales { get; set; }

    public virtual ICollection<Usuarios> Usuarios { get; set; }

    #endregion

}
