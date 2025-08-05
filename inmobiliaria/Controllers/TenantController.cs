using Inmobiliaria.Controllers.Contracts;
using Inmobiliaria.Data;
using Inmobiliaria.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TenantController : ControllerBase
{
    private readonly AppDbContext _context;

    public TenantController(AppDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Crear un nuevo tenant
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> CrearTenant([FromBody] TenantContract dto)
    {
        if (dto == null)
            return BadRequest("Los datos del tenant son requeridos.");

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        if (!string.IsNullOrWhiteSpace(dto.Cuit))
        {
            var existeTenant = await _context.Tenants
                .AnyAsync(t => t.Cuit == dto.Cuit && !t.Eliminado);
            if (existeTenant)
                return BadRequest("Ya existe un tenant con este CUIT.");
        }

        var nuevoTenant = new Tenants
        {
            // IdTenant es autoincremental, no se asigna manualmente
            Nombre = dto.Nombre,
            Cuit = dto.Cuit,
            Email = dto.Email,
            Telefono = dto.Telefono,
            Direccion = dto.Direccion,
            Activo = true,
            Eliminado = false,
            FechaCreacion = DateTime.Now,
            FechaActualizacion = DateTime.Now,
            FechaEliminacion = null
        };

        _context.Tenants.Add(nuevoTenant);
        await _context.SaveChangesAsync();

        var response = MapToResponse(nuevoTenant);

        return CreatedAtAction(nameof(ObtenerTenantPorId),
            new { id = nuevoTenant.IdTenant },
            new { mensaje = "Tenant creado correctamente", tenant = response });
    }

    /// <summary>
    /// Obtener todos los tenants activos
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> ObtenerTenants([FromQuery] bool incluirInactivos = false)
    {
        var query = _context.Tenants.Where(t => !t.Eliminado);

        if (!incluirInactivos)
        {
            query = query.Where(t => t.Activo);
        }

        var tenants = await query
            .OrderBy(t => t.Nombre)
            .Select(t => MapToResponse(t))
            .ToListAsync();

        return Ok(tenants);
    }

    /// <summary>
    /// Obtener un tenant por ID
    /// </summary>
    [HttpGet("{id:long}")]
    public async Task<IActionResult> ObtenerTenantPorId(long id)
    {
        var tenant = await _context.Tenants
            .FirstOrDefaultAsync(t => t.IdTenant == id && !t.Eliminado);

        if (tenant == null)
            return NotFound("Tenant no encontrado.");

        var response = MapToResponse(tenant);
        return Ok(response);
    }

    /// <summary>
    /// Actualizar un tenant
    /// </summary>
    [HttpPut("{id:long}")]
    public async Task<IActionResult> ActualizarTenant(long id, [FromBody] TenantUpdateContract dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var tenant = await _context.Tenants
            .FirstOrDefaultAsync(t => t.IdTenant == id && !t.Eliminado);

        if (tenant == null)
            return NotFound("Tenant no encontrado.");

        if (!string.IsNullOrWhiteSpace(dto.Cuit) && dto.Cuit != tenant.Cuit)
        {
            var existeTenant = await _context.Tenants
                .AnyAsync(t => t.Cuit == dto.Cuit && t.IdTenant != id && !t.Eliminado);

            if (existeTenant)
                return BadRequest("Ya existe otro tenant con este CUIT.");
        }

        if (!string.IsNullOrWhiteSpace(dto.Nombre)) tenant.Nombre = dto.Nombre;
        if (dto.Cuit != null) tenant.Cuit = dto.Cuit;
        if (dto.Email != null) tenant.Email = dto.Email;
        if (dto.Telefono != null) tenant.Telefono = dto.Telefono;
        if (dto.Direccion != null) tenant.Direccion = dto.Direccion;
        if (dto.Activo.HasValue) tenant.Activo = dto.Activo.Value;

        tenant.FechaActualizacion = DateTime.Now;

        await _context.SaveChangesAsync();

        var response = MapToResponse(tenant);
        return Ok(new { mensaje = "Tenant actualizado correctamente", tenant = response });
    }

    /// <summary>
    /// Activar/Desactivar un tenant
    /// </summary>
    [HttpPatch("{id:long}/estado")]
    public async Task<IActionResult> CambiarEstadoTenant(long id, [FromBody] bool activo)
    {
        var tenant = await _context.Tenants
            .FirstOrDefaultAsync(t => t.IdTenant == id && !t.Eliminado);

        if (tenant == null)
            return NotFound("Tenant no encontrado.");

        tenant.Activo = activo;
        tenant.FechaActualizacion = DateTime.Now;

        await _context.SaveChangesAsync();

        return Ok(new
        {
            mensaje = $"Tenant {(activo ? "activado" : "desactivado")} correctamente",
            estado = activo
        });
    }

    /// <summary>
    /// Eliminar un tenant (soft delete)
    /// </summary>
    [HttpDelete("{id:long}")]
    public async Task<IActionResult> EliminarTenant(long id)
    {
        var tenant = await _context.Tenants
            .FirstOrDefaultAsync(t => t.IdTenant == id && !t.Eliminado);

        if (tenant == null)
            return NotFound("Tenant no encontrado.");

        tenant.Eliminado = true;
        tenant.FechaEliminacion = DateTime.Now;
        tenant.FechaActualizacion = DateTime.Now;

        await _context.SaveChangesAsync();

        return Ok(new { mensaje = "Tenant eliminado correctamente" });
    }

    /// <summary>
    /// Buscar tenants por nombre o CUIT
    /// </summary>
    [HttpGet("buscar")]
    public async Task<IActionResult> BuscarTenants([FromQuery] string termino)
    {
        if (string.IsNullOrWhiteSpace(termino))
            return BadRequest("El término de búsqueda es obligatorio.");

        var tenants = await _context.Tenants
            .Where(t => !t.Eliminado && t.Activo &&
                        (t.Nombre.Contains(termino) || (t.Cuit != null && t.Cuit.Contains(termino))))
            .OrderBy(t => t.Nombre)
            .Select(t => MapToResponse(t))
            .ToListAsync();

        return Ok(tenants);
    }

    private static TenantResponseContract MapToResponse(Tenants tenant)
    {
        return new TenantResponseContract
        {
            IdTenant = tenant.IdTenant,
            Nombre = tenant.Nombre,
            Cuit = tenant.Cuit,
            Email = tenant.Email,
            Telefono = tenant.Telefono,
            Direccion = tenant.Direccion,
            Activo = tenant.Activo,
            FechaCreacion = tenant.FechaCreacion,
            FechaActualizacion = tenant.FechaActualizacion
        };
    }
}
