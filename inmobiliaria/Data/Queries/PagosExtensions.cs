using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Queries;

public static partial class PagosExtensions
{
    #region Generated Extensions
    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Pagos> ByFechaPago(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Pagos> queryable, DateOnly fechaPago)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.FechaPago == fechaPago);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Pagos> ByIdContrato(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Pagos> queryable, long idContrato)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdContrato == idContrato);
    }

    public static Inmobiliaria.Data.Entities.Pagos? GetByKey(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Pagos> queryable, long idPago)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Pagos> dbSet)
            return dbSet.Find(idPago);

        return queryable.FirstOrDefault(q => q.IdPago == idPago);
    }

    public static async System.Threading.Tasks.ValueTask<Inmobiliaria.Data.Entities.Pagos?> GetByKeyAsync(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Pagos> queryable, long idPago, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Pagos> dbSet)
            return await dbSet.FindAsync(new object[] { idPago }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.IdPago == idPago, cancellationToken);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Pagos> ByIdTenant(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Pagos> queryable, long idTenant)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdTenant == idTenant);
    }

    #endregion

}
