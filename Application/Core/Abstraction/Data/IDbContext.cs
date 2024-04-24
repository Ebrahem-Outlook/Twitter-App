using Domain.Core.Primitives;
using Microsoft.EntityFrameworkCore;

namespace Application.Core.Abstraction.Data;

public interface IDbContext
{
    // Set
    Task<DbSet<TEntity>> Set<TEntity>() where TEntity : Entity;

    // Insert
    Task Insert<TEntity>(TEntity entity) where TEntity : Entity;

    // InsertRange
    Task InsertRange<TEntity>(IReadOnlyCollection<TEntity> entities) where TEntity : Entity;
    
    // Remove
    Task Remove<TEntity>(TEntity entity) where TEntity : Entity;

    // GetById
    Task<TEntity> GetById<TEntity>(Guid id) where TEntity : Entity;
}
