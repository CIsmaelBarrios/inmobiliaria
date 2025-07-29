using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Queries;

public static partial class PropiedadesExtensions
{
    #region Generated Extensions
    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propiedades> ByCiudad(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propiedades> queryable, string ciudad)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => (q.Ciudad == ciudad || (ciudad == null && q.Ciudad == null)));
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propiedades> ByEstado(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propiedades> queryable, string estado)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Estado == estado);
    }

    public static Inmobiliaria.Data.Entities.Propiedades? GetByKey(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propiedades> queryable, Guid idPropiedad)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Propiedades> dbSet)
            return dbSet.Find(idPropiedad);

        return queryable.FirstOrDefault(q => q.IdPropiedad == idPropiedad);
    }

    public static async System.Threading.Tasks.ValueTask<Inmobiliaria.Data.Entities.Propiedades?> GetByKeyAsync(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propiedades> queryable, Guid idPropiedad, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Inmobiliaria.Data.Entities.Propiedades> dbSet)
            return await dbSet.FindAsync(new object[] { idPropiedad }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.IdPropiedad == idPropiedad, cancellationToken);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propiedades> ByIdPropietario(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propiedades> queryable, Guid idPropietario)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdPropietario == idPropietario);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propiedades> ByIdTenant(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propiedades> queryable, Guid idTenant)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.IdTenant == idTenant);
    }

    public static System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propiedades> ByTipo(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.Propiedades> queryable, string tipo)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Tipo == tipo);
    }

    #endregion

}
