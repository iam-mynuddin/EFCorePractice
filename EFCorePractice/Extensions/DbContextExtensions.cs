using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public static class DbContextExtensions
{
    public static IQueryable<TEntity> IncludeAll<TEntity>(this IQueryable<TEntity> query) where TEntity : class
    {
        var entityType = typeof(TEntity);
        var navigations = entityType.GetProperties()
            .Where(p => p.PropertyType.IsClass && p.PropertyType != typeof(string));

        foreach (var navigationProperty in navigations)
        {
            query = query.Include(navigationProperty.Name);
        }

        return query;
    }
    public static IQueryable<T> IncludeOnly<T>(this IQueryable<T> query, params string[] navigationProperties) where T : class
    {
        foreach (var navigationProperty in navigationProperties)
        {
            query = query.IncludeNestedProperty(navigationProperty);
        }
        return query;
    }

    private static IQueryable<T> IncludeNestedProperty<T>(this IQueryable<T> query, string navigationProperty) where T : class
    {
        var properties = navigationProperty.Split('.');
        IQueryable<T> result = query;
        foreach (var property in properties)
        {
            var propertyInfo = typeof(T).GetProperty(property);
            if (propertyInfo == null)
            {
                throw new ArgumentException($"Property: {property} not found in entity {typeof(T).Name}.");
            }
            result = result.Include(property);
        }
        return result;
    }
}
