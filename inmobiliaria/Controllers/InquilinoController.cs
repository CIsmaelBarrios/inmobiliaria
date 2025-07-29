using Microsoft.AspNetCore.Mvc;
using Inmobiliaria.Controllers.Contracts;
using Inmobiliaria.Data;
using Inmobiliaria.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InquilinoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InquilinoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Inquilino
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InquilinosContract>>> GetInquilinos()
        {
            var inquilinos = await _context.Inquilinos
                .Where(i => !i.Eliminado)
                .ToListAsync();

            var result = inquilinos.Select(i => new InquilinosContract
            {
                IdInquilino = i.IdInquilino,
                IdTenant = i.IdTenant,
                Nombre = i.Nombre,
                Apellido = i.Apellido,
                Dni = i.Dni,
                Cuit = i.Cuit,
                Email = i.Email,
                Telefono = i.Telefono,
                Direccion = i.Direccion,
                FechaNacimiento = i.FechaNacimiento,
                Ocupacion = i.Ocupacion,
                IngresosDeclarados = i.IngresosDeclarados,
                Observaciones = i.Observaciones,
                Activo = i.Activo,
                FechaCreacion = i.FechaCreacion,
                FechaActualizacion = i.FechaActualizacion,
                Eliminado = i.Eliminado,
                FechaEliminacion = i.FechaEliminacion
            }).ToList();

            return Ok(result);
        }

        // GET: api/Inquilino/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<InquilinosContract>> GetInquilino(Guid id)
        {
            var i = await _context.Inquilinos.FirstOrDefaultAsync(x => x.IdInquilino == id && !x.Eliminado);

            if (i == null)
                return NotFound();

            var result = new InquilinosContract
            {
                IdInquilino = i.IdInquilino,
                IdTenant = i.IdTenant,
                Nombre = i.Nombre,
                Apellido = i.Apellido,
                Dni = i.Dni,
                Cuit = i.Cuit,
                Email = i.Email,
                Telefono = i.Telefono,
                Direccion = i.Direccion,
                FechaNacimiento = i.FechaNacimiento,
                Ocupacion = i.Ocupacion,
                IngresosDeclarados = i.IngresosDeclarados,
                Observaciones = i.Observaciones,
                Activo = i.Activo,
                FechaCreacion = i.FechaCreacion,
                FechaActualizacion = i.FechaActualizacion,
                Eliminado = i.Eliminado,
                FechaEliminacion = i.FechaEliminacion
            };

            return Ok(result);
        }

        // POST: api/Inquilino
        [HttpPost]
        public async Task<ActionResult> CrearInquilino(InquilinoCreateContract dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var ahora = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);

            var nuevo = new Inquilinos
            {
                IdInquilino = Guid.NewGuid(),
                IdTenant = dto.IdTenant ?? Guid.Empty,
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Dni = dto.Dni,
                Cuit = dto.Cuit,
                Email = dto.Email,
                Telefono = dto.Telefono,
                Direccion = dto.Direccion,
                FechaNacimiento = dto.FechaNacimiento,
                Ocupacion = dto.Ocupacion,
                IngresosDeclarados = dto.IngresosDeclarados,
                Observaciones = dto.Observaciones,
                Activo = true,
                FechaCreacion = ahora,
                FechaActualizacion = ahora,
                Eliminado = false
            };

            _context.Inquilinos.Add(nuevo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetInquilino), new { id = nuevo.IdInquilino }, null);
        }

        // PUT: api/Inquilino/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarInquilino(Guid id, InquilinoCreateContract dto)
        {
            var inquilino = await _context.Inquilinos.FirstOrDefaultAsync(x => x.IdInquilino == id && !x.Eliminado);
            if (inquilino == null)
                return NotFound();

            inquilino.Nombre = dto.Nombre;
            inquilino.Apellido = dto.Apellido;
            inquilino.Dni = dto.Dni;
            inquilino.Cuit = dto.Cuit;
            inquilino.Email = dto.Email;
            inquilino.Telefono = dto.Telefono;
            inquilino.Direccion = dto.Direccion;
            inquilino.FechaNacimiento = dto.FechaNacimiento;
            inquilino.Ocupacion = dto.Ocupacion;
            inquilino.IngresosDeclarados = dto.IngresosDeclarados;
            inquilino.Observaciones = dto.Observaciones;
            inquilino.FechaActualizacion = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/Inquilino/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarInquilino(Guid id)
        {
            var inquilino = await _context.Inquilinos.FindAsync(id);

            if (inquilino == null || inquilino.Eliminado)
                return NotFound();

            var ahora = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);

            inquilino.Eliminado = true;
            inquilino.FechaEliminacion = ahora;
            inquilino.Activo = false;
            inquilino.FechaActualizacion = ahora;

            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
