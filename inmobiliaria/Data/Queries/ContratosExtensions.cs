using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Queries;

public static partial class ContratosExtensions
{
    #region Generated Extensions
    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> ByEstado(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> queryable, string estado)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Estado == estado);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> ByFechaInicioFechaFin(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> queryable, DateOnly fechaInicio, DateOnly fechaFin)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.FechaInicio == fechaInicio
            && q.FechaFin == fechaFin);
    }

    public static Inmobiliaria.Data.Entities.Contratos? GetByKey(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> queryable, Guid idContrato)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Contratos> dbSet)
            return dbSet.Find(idContrato);

        return queryable.FirstOrDefault(q => q.IdContrato == idContrato);
    }

    public static async System.Threading.Tasks.ValueTask<Inmobiliaria.Data.Entities.Contratos?> GetByKeyAsync(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> queryable, Guid idContrato, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Contratos> dbSet)
            return await dbSet.FindAsync(new object[] { idContrato }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.IdContrato == idContrato, cancellationToken);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> ByIdInquilino(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> queryable, Guid idInquilino)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdInquilino == idInquilino);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> ByIdPropiedad(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> queryable, Guid? idPropiedad)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => (q.IdPropiedad == idPropiedad || (idPropiedad == null && q.IdPropiedad == null)));
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> ByIdTenant(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> queryable, Guid idTenant)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdTenant == idTenant);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> ByIdUnidad(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Contratos> queryable, Guid? idUnidad)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => (q.IdUnidad == idUnidad || (idUnidad == null && q.IdUnidad == null)));
    }

    #endregion

}
