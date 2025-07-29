using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Queries;

public static partial class UsuariosExtensions
{
    #region Generated Extensions
    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Usuarios> ByEmail(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Usuarios> queryable, string email)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Email == email);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Usuarios> ByIdTenant(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Usuarios> queryable, Guid idTenant)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdTenant == idTenant);
    }

    public static Inmobiliaria.Data.Entities.Usuarios? GetByKey(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Usuarios> queryable, Guid idUsuario)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Usuarios> dbSet)
            return dbSet.Find(idUsuario);

        return queryable.FirstOrDefault(q => q.IdUsuario == idUsuario);
    }

    public static async System.Threading.Tasks.ValueTask<Inmobiliaria.Data.Entities.Usuarios?> GetByKeyAsync(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Usuarios> queryable, Guid idUsuario, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Usuarios> dbSet)
            return await dbSet.FindAsync(new object[] { idUsuario }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.IdUsuario == idUsuario, cancellationToken);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Usuarios> ByRol(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Usuarios> queryable, string rol)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Rol == rol);
    }

    #endregion

}
