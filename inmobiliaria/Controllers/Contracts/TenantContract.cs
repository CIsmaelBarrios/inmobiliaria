using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria.Controllers.Contracts;

public class TenantContract
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
    public string Nombre { get; set; } = string.Empty;

    [StringLength(20, ErrorMessage = "El CUIT no puede exceder los 20 caracteres")]
    public string? Cuit { get; set; }

    [EmailAddress(ErrorMessage = "El formato del email no es válido")]
    [StringLength(100, ErrorMessage = "El email no puede exceder los 100 caracteres")]
    public string? Email { get; set; }

    [StringLength(20, ErrorMessage = "El teléfono no puede exceder los 20 caracteres")]
    public string? Telefono { get; set; }

    [StringLength(200, ErrorMessage = "La dirección no puede exceder los 200 caracteres")]
    public string? Direccion { get; set; }
}
