using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Data.Queries;

public static partial class VersionInfoExtensions
{
    #region Generated Extensions
    public static Inmobiliaria.Data.Entities.VersionInfo? GetByVersion(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.VersionInfo> queryable, long version)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.FirstOrDefault(q => q.Version == version);
    }

    public static async System.Threading.Tasks.Task<Inmobiliaria.Data.Entities.VersionInfo?> GetByVersionAsync(this System.Linq.IQueryable<Inmobiliaria.Data.Entities.VersionInfo> queryable, long version, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return await queryable.FirstOrDefaultAsync(q => q.Version == version, cancellationToken);
    }

    #endregion

}
