using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Queries;

public static partial class TenantsExtensions
{
    #region Generated Extensions
    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Tenants> ByActivo(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Tenants> queryable, bool activo)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Activo == activo);
    }

    public static Inmobiliaria.Data.Entities.Tenants? GetByKey(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Tenants> queryable, Guid idTenant)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Tenants> dbSet)
            return dbSet.Find(idTenant);

        return queryable.FirstOrDefault(q => q.IdTenant == idTenant);
    }

    public static async System.Threading.Tasks.ValueTask<Inmobiliaria.Data.Entities.Tenants?> GetByKeyAsync(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Tenants> queryable, Guid idTenant, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Tenants> dbSet)
            return await dbSet.FindAsync(new object[] { idTenant }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.IdTenant == idTenant, cancellationToken);
    }

    #endregion

}
