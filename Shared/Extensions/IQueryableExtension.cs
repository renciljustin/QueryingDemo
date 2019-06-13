using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using PaginationDemo.Core.Models.Tools;

namespace PaginationDemo.Shared.Extensions
{
    public static class IQueryableExtension
    {
        public static IQueryable<TEntity> ApplyOrdering<TEntity>(this IQueryable<TEntity> entity, ObjectQuery query, Dictionary<string, Expression<Func<TEntity, object>>> columnsMap)
        {
            if (!string.IsNullOrWhiteSpace(query.SortBy) && columnsMap.ContainsKey(query.SortBy))
            {
                return !query.IsSortDescending
                    ? entity.OrderBy(columnsMap[query.SortBy])
                    : entity.OrderByDescending(columnsMap[query.SortBy]);
            }
            return entity;
        }

        public static IQueryable<TEntity> ApplyPaging<TEntity>(this IQueryable<TEntity> entity, ObjectQuery query)
        {
            if (query.Page <= 0)
                query.Page = 1;
                
            if (query.PageSize <= 0)
                query.PageSize = 50;

            return entity.Skip((query.Page - 1) * query.PageSize).Take(query.PageSize);
        }
    }
}