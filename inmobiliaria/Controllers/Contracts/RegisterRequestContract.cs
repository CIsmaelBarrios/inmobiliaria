namespace inmobiliaria.Controllers.Contracts
{

        public class RegisterRequest
        {
            public string Nombre { get; set; } = null!;
            public string Apellido { get; set; } = null!;
            public string Email { get; set; } = null!;
            public string Password { get; set; } = null!;
            public string TenantNombre { get; set; } = null!;
            public string Rol { get; set; } = "agente"; // opcional
            public string? Telefono { get; set; }
        }
    

}
