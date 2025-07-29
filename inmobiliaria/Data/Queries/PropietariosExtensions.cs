using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Queries;

public static partial class PropietariosExtensions
{
    #region Generated Extensions
    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propietarios> ByDni(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propietarios> queryable, string dni)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Dni == dni);
    }

    public static Inmobiliaria.Data.Entities.Propietarios? GetByKey(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propietarios> queryable, Guid idPropietario)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Propietarios> dbSet)
            return dbSet.Find(idPropietario);

        return queryable.FirstOrDefault(q => q.IdPropietario == idPropietario);
    }

    public static async System.Threading.Tasks.ValueTask<Inmobiliaria.Data.Entities.Propietarios?> GetByKeyAsync(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propietarios> queryable, Guid idPropietario, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Propietarios> dbSet)
            return await dbSet.FindAsync(new object[] { idPropietario }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.IdPropietario == idPropietario, cancellationToken);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propietarios> ByIdTenant(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propietarios> queryable, Guid idTenant)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdTenant == idTenant);
    }

    #endregion

}
