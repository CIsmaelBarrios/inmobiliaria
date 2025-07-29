namespace inmobiliaria.Controllers.Contracts
{
    public class LoginRequest
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string TenantNombre { get; set; } = null!; // opcional si usás subdominios o tenant seleccionable
    }

}
