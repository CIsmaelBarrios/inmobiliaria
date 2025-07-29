using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Queries;

public static partial class DocumentosExtensions
{
    #region Generated Extensions
    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> ByEntidadTipoEntidadId(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> queryable, string entidadTipo, Guid entidadId)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.EntidadTipo == entidadTipo
            && q.EntidadId == entidadId);
    }

    public static Inmobiliaria.Data.Entities.Documentos? GetByKey(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> queryable, Guid idDocumento)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Documentos> dbSet)
            return dbSet.Find(idDocumento);

        return queryable.FirstOrDefault(q => q.IdDocumento == idDocumento);
    }

    public static async System.Threading.Tasks.ValueTask<Inmobiliaria.Data.Entities.Documentos?> GetByKeyAsync(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> queryable, Guid idDocumento, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Documentos> dbSet)
            return await dbSet.FindAsync(new object[] { idDocumento }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.IdDocumento == idDocumento, cancellationToken);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> ByIdTenant(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> queryable, Guid idTenant)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdTenant == idTenant);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> BySubidoPor(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> queryable, Guid? subidoPor)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => (q.SubidoPor == subidoPor || (subidoPor == null && q.SubidoPor == null)));
    }

    #endregion

}
