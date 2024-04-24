namespace Domain.Core.Primitives;

/// <summary>
/// Represent the AggregateRootBASe class.
/// </summary>
public abstract class AggregateRoot : Entity
{
    /// <summary>
    /// Create instance of <see cref="AggregateRoot"/> class.
    /// </summary>
    /// <param name="id"></param>
    protected AggregateRoot(Guid id) : base(id) { }

    protected AggregateRoot() { }




}
