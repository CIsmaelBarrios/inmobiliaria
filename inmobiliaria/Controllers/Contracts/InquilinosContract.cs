namespace Inmobiliaria.Controllers.Contracts
{
    public class InquilinosContract
    {
        public Guid? IdInquilino { get; set; }
        public Guid? IdTenant { get; set; }

        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Dni { get; set; } = null!;

        public string? Cuit { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }

        public DateOnly? FechaNacimiento { get; set; }
        public string? Ocupacion { get; set; }
        public decimal? IngresosDeclarados { get; set; }

        public string? Observaciones { get; set; }

        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool Eliminado { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
