namespace Inmobiliaria.Controllers.Contracts
{
    public class InquilinoDetalleContract
    {
        public Guid IdInquilino { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Dni { get; set; } = null!;
        public string? Email { get; set; }

        public int ContratosActivos { get; set; }
        public decimal? IngresosDeclarados { get; set; }
    }
}
