﻿using System.Linq.Expressions;
using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using Core.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Persistence.Repositories;

public class EntityFrameworkRepositoryBase<TEntity, TId, TContext>(TContext context) : IAsyncRepository<TEntity, TId>
    where TEntity : Entity<TId>
    where TContext : DbContext
{
    public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        if (entity is null)
            throw new NotFoundException("Entity is not found!");
        context.Set<TEntity>().Entry(entity).State = EntityState.Added;
        await context.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entities,
        CancellationToken cancellationToken = default)
    {
        if (entities is null)
            throw new NotFoundException("Entities is not found!");
        await context.Set<TEntity>().AddRangeAsync(entities, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
        return entities;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        if (entity is null)
            throw new NotFoundException("Entity is not found!");
        entity.UpdatedTime = DateTime.Now;
        context.Set<TEntity>().Entry(entity).State = EntityState.Modified;
        await context.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<ICollection<TEntity>> UpdateRangeAsync(ICollection<TEntity> entities,
        CancellationToken cancellationToken = default)
    {
        if (entities is null)
            throw new NotFoundException("Entities is not found!");
        foreach (var entity in entities)
        {
            entity.UpdatedTime = DateTime.Now;
            context.Set<TEntity>().Entry(entity).State = EntityState.Modified;
        }

        await context.SaveChangesAsync(cancellationToken);
        return entities;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        if (entity is null)
            throw new NotFoundException("Entity is not found!");
        entity.UpdatedTime = DateTime.Now;
        entity.IsDeleted = true;
        context.Set<TEntity>().Entry(entity).State = EntityState.Modified;
        await context.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<ICollection<TEntity>> DeleteRangeAsync(ICollection<TEntity> entities,
        CancellationToken cancellationToken = default)
    {
        if (entities is null)
            throw new NotFoundException("Entities is not found!");
        foreach (var entity in entities)
        {
            entity.UpdatedTime = DateTime.Now;
            entity.IsDeleted = true;
            context.Set<TEntity>().Entry(entity).State = EntityState.Modified;
        }

        await context.SaveChangesAsync(cancellationToken);
        return entities;
    }

    public async Task<TEntity> HardDeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        if (entity is null)
            throw new NotFoundException("Entity is not found!");
        context.Set<TEntity>().Remove(entity);
        await context.SaveChangesAsync(cancellationToken);
        return entity;
    }


    public async Task<ICollection<TEntity>> HardDeleteRangeAsync(ICollection<TEntity> entities,
        CancellationToken cancellationToken = default)
    {
        if (entities is null)
            throw new NotFoundException("Entities is not found!");
        context.Set<TEntity>().RemoveRange(entities);
        await context.SaveChangesAsync(cancellationToken);
        return entities;
    }


    public async Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null,
        bool ignoreQueryFilters = false,
        bool enableTracking = true,
        bool include = true,
        CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> query = context.Set<TEntity>();
        if (enableTracking is false)
            query = query.AsNoTracking();
        if (include is false)
            query = query.IgnoreAutoIncludes();
        if (filter is not null)
            query = query.Where(filter);
        if (ignoreQueryFilters)
            query = query.IgnoreQueryFilters();
        return await query.ToListAsync(cancellationToken);
    }

    public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> filter, bool ignoreQueryFilters = false,
        bool enableTracking = true,
        bool include = true,
        CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> query = context.Set<TEntity>();
        if (enableTracking is false)
            query = query.AsNoTracking();
        if (include is false)
            query = query.IgnoreAutoIncludes();
        if (ignoreQueryFilters)
            query = query.IgnoreQueryFilters();
        return await query.FirstOrDefaultAsync(filter, cancellationToken);
    }

    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? filter = null, bool ignoreQueryFilters = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> query = context.Set<TEntity>();
        if (enableTracking is false)
            query = query.AsNoTracking();
        if (filter is not null)
            query = query.Where(filter);
        if (ignoreQueryFilters)
            query = query.IgnoreQueryFilters();
        return await query.AnyAsync(cancellationToken);
    }

    public async Task<TEntity?> GetByIdAsync(TId id, bool ignoreQueryFilters = false, bool enableTracking = true,
        bool include = true,
        CancellationToken cancellationToken = default)
    {
        if (id is null)
            throw new NotFoundException("ID is not found!");
        IQueryable<TEntity> query = context.Set<TEntity>();
        if (enableTracking is false)
            query = query.AsNoTracking();
        if (include is false)
            query = query.IgnoreAutoIncludes();
        if (ignoreQueryFilters)
            query = query.IgnoreQueryFilters();
        return await query.FirstOrDefaultAsync(x => x.Id != null && x.Id.Equals(id),
            cancellationToken);
    }

    public async Task<ICollection<TEntity?>> GetByIdsAsync(ICollection<TId>? ids, bool ignoreQueryFilters = false,
        bool enableTracking = true, bool include = true,
        CancellationToken cancellationToken = default)
    {
        if (ids == null || ids.Count == 0)
            return new List<TEntity?>();
        IQueryable<TEntity> query = context.Set<TEntity>();
        if (!enableTracking)
            query = query.AsNoTracking();
        if (!include)
            query = query.IgnoreAutoIncludes();
        if (ignoreQueryFilters)
            query = query.IgnoreQueryFilters();
        query = query.Where(x => ids.Contains(x.Id));
        return (await query.ToListAsync(cancellationToken))!;
    }

    public async Task<int> CountAsync(Expression<Func<TEntity, bool>>? filter = null, bool ignoreQueryFilters = false,
        bool include = true,
        CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> query = context.Set<TEntity>();
        if (include is false)
            query = query.IgnoreAutoIncludes();
        if (filter is not null)
            query = query.Where(filter);
        if (ignoreQueryFilters)
            query = query.IgnoreQueryFilters();
        return await query.CountAsync(cancellationToken);
    }
}