namespace Application.Core.Abstraction.Data;

public interface IUnitOfWork
{
    // save changes.
    void SaveChanges<TEntity>(CancellationToken cancellationToken);
}
