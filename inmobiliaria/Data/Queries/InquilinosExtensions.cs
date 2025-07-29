using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Queries;

public static partial class InquilinosExtensions
{
    #region Generated Extensions
    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Inquilinos> ByDni(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Inquilinos> queryable, string dni)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Dni == dni);
    }

    public static Inmobiliaria.Data.Entities.Inquilinos? GetByKey(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Inquilinos> queryable, Guid idInquilino)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Inquilinos> dbSet)
            return dbSet.Find(idInquilino);

        return queryable.FirstOrDefault(q => q.IdInquilino == idInquilino);
    }

    public static async System.Threading.Tasks.ValueTask<Inmobiliaria.Data.Entities.Inquilinos?> GetByKeyAsync(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Inquilinos> queryable, Guid idInquilino, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Inquilinos> dbSet)
            return await dbSet.FindAsync(new object[] { idInquilino }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.IdInquilino == idInquilino, cancellationToken);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Inquilinos> ByIdTenant(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Inquilinos> queryable, Guid idTenant)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdTenant == idTenant);
    }

    #endregion

}
