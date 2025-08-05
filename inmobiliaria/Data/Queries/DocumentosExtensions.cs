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
    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> ByEntidadTipo(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> queryable, string entidadTipo)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.EntidadTipo == entidadTipo);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> ByFechaSubida(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> queryable, DateTime fechaSubida)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.FechaSubida == fechaSubida);
    }

    public static Inmobiliaria.Data.Entities.Documentos? GetByKey(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> queryable, long idDocumento)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Documentos> dbSet)
            return dbSet.Find(idDocumento);

        return queryable.FirstOrDefault(q => q.IdDocumento == idDocumento);
    }

    public static async System.Threading.Tasks.ValueTask<Inmobiliaria.Data.Entities.Documentos?> GetByKeyAsync(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> queryable, long idDocumento, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Documentos> dbSet)
            return await dbSet.FindAsync(new object[] { idDocumento }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.IdDocumento == idDocumento, cancellationToken);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> ByIdTenant(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> queryable, long idTenant)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdTenant == idTenant);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> BySubidoPor(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Documentos> queryable, long? subidoPor)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => (q.SubidoPor == subidoPor || (subidoPor == null && q.SubidoPor == null)));
    }

    #endregion

}
