using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Queries;

public static partial class GarantiasExtensions
{
    #region Generated Extensions
    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Garantias> ByIdContrato(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Garantias> queryable, Guid idContrato)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdContrato == idContrato);
    }

    public static Inmobiliaria.Data.Entities.Garantias? GetByKey(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Garantias> queryable, Guid idGarantia)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Garantias> dbSet)
            return dbSet.Find(idGarantia);

        return queryable.FirstOrDefault(q => q.IdGarantia == idGarantia);
    }

    public static async System.Threading.Tasks.ValueTask<Inmobiliaria.Data.Entities.Garantias?> GetByKeyAsync(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Garantias> queryable, Guid idGarantia, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Garantias> dbSet)
            return await dbSet.FindAsync(new object[] { idGarantia }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.IdGarantia == idGarantia, cancellationToken);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Garantias> ByIdTenant(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Garantias> queryable, Guid idTenant)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdTenant == idTenant);
    }

    #endregion

}
