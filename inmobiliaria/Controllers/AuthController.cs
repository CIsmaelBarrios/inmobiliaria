using BCrypt.Net;
using inmobiliaria.Controllers.Contracts;
using Inmobiliaria.Data;
using Inmobiliaria.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/Auth/login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Usuarios? usuario = null;
            Tenants? tenant = null;

            if (!string.IsNullOrWhiteSpace(request.TenantNombre))
            {
                tenant = await _context.Tenants
                    .FirstOrDefaultAsync(t => t.Nombre == request.TenantNombre && t.Activo && !t.Eliminado);

                if (tenant == null)
                    return Unauthorized("El tenant no existe o está desactivado.");

                usuario = await _context.Usuarios
                    .FirstOrDefaultAsync(u =>
                        u.Email == request.Email &&
                        u.IdTenant == tenant.IdTenant &&
                        u.Activo && !u.Eliminado);
            }
            else
            {
                // Login de superadmin (sin tenant)
                usuario = await _context.Usuarios
                    .FirstOrDefaultAsync(u =>
                        u.Email == request.Email &&
                        u.Rol.ToLower() == "superadmin" &&
                        u.Activo && !u.Eliminado);
            }

            if (usuario == null)
                return Unauthorized("Credenciales incorrectas.");

            if (!BCrypt.Net.BCrypt.Verify(request.Password, usuario.PasswordHash))
                return Unauthorized("Credenciales incorrectas.");

            usuario.FechaUltimoAcceso = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                usuario.IdUsuario,
                usuario.Nombre,
                usuario.Apellido,
                usuario.Email,
                usuario.Rol,
                usuario.IdTenant,
                TenantNombre = tenant?.Nombre ?? "Global"
            });
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // 1. Verificar que el tenant exista
            var tenant = await _context.Tenants
                .FirstOrDefaultAsync(t => t.Nombre == request.TenantNombre && t.Activo && !t.Eliminado);

            if (tenant == null)
                return BadRequest("El tenant no existe o está desactivado.");

            // 2. Verificar que el email no esté en uso dentro del mismo tenant
            var existe = await _context.Usuarios
                .AnyAsync(u => u.IdTenant == tenant.IdTenant && u.Email == request.Email && !u.Eliminado);

            if (existe)
                return Conflict("Ya existe un usuario con ese email en el tenant.");

            // 3. Crear usuario con fechas en Kind=Unspecified
            var nuevo = new Usuarios
            {
                IdUsuario = Guid.NewGuid(),
                IdTenant = tenant.IdTenant,
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                Email = request.Email,
                Telefono = request.Telefono,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
                Rol = request.Rol.ToLower(),
                Activo = true,
                Eliminado = false,
                FechaCreacion = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified)
            };

            _context.Usuarios.Add(nuevo);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                Message = "Usuario registrado correctamente",
                Usuario = new
                {
                    nuevo.IdUsuario,
                    nuevo.Nombre,
                    nuevo.Apellido,
                    nuevo.Email,
                    nuevo.Rol,
                    nuevo.IdTenant
                }
            });
        }
    }
}
