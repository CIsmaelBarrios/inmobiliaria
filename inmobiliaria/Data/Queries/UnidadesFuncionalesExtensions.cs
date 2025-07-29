using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Queries;

public static partial class UnidadesFuncionalesExtensions
{
    #region Generated Extensions
    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.UnidadesFuncionales> ByCodigo(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.UnidadesFuncionales> queryable, string codigo)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Codigo == codigo);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.UnidadesFuncionales> ByEstado(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.UnidadesFuncionales> queryable, string estado)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Estado == estado);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.UnidadesFuncionales> ByIdPropiedad(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.UnidadesFuncionales> queryable, Guid idPropiedad)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdPropiedad == idPropiedad);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.UnidadesFuncionales> ByIdTenant(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.UnidadesFuncionales> queryable, Guid idTenant)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdTenant == idTenant);
    }

    public static Inmobiliaria.Data.Entities.UnidadesFuncionales? GetByKey(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.UnidadesFuncionales> queryable, Guid idUnidad)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.UnidadesFuncionales> dbSet)
            return dbSet.Find(idUnidad);

        return queryable.FirstOrDefault(q => q.IdUnidad == idUnidad);
    }

    public static async System.Threading.Tasks.ValueTask<Inmobiliaria.Data.Entities.UnidadesFuncionales?> GetByKeyAsync(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.UnidadesFuncionales> queryable, Guid idUnidad, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.UnidadesFuncionales> dbSet)
            return await dbSet.FindAsync(new object[] { idUnidad }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.IdUnidad == idUnidad, cancellationToken);
    }

    #endregion

}
