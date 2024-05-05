using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

public static class DbContextExtensions
{
    public static IQueryable<TEntity> IncludeAll<TEntity>(this DbContext context) where TEntity : class
    {
        var entityType = context.Model.FindEntityType(typeof(TEntity));
        var navigations = entityType.GetNavigations().ToList();

        IQueryable<TEntity> query = context.Set<TEntity>();

        foreach (var navigationProperty in navigations)
        {
            query = query.Include(navigationProperty.Name);
        }

        return query;
    }
}
