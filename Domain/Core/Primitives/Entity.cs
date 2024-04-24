
namespace Domain.Core.Primitives;

/// <summary>
/// Represint The Entity base class.
/// </summary>
public abstract class Entity : IEquatable<Entity?>
{
    /// <summary>
    /// Create an instance of <see cref="Entity"/> class.
    /// </summary>
    /// <param name="id">The identifer of entity.</param>
    protected Entity(Guid id)
    {
        Id = id;
    }

    /// <summary>
    /// Required by EF Core.
    /// </summary>
    protected Entity() { }

    /// <summary>
    /// Get and Set the identifer of the entity.
    /// </summary>
    protected Guid Id { get; private set; }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Entity);
    }

    public bool Equals(Entity? other)
    {
        return other is not null &&
               Id.Equals(other.Id);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }

    public static bool operator ==(Entity? left, Entity? right)
    {
        return EqualityComparer<Entity>.Default.Equals(left, right);
    }

    public static bool operator !=(Entity? left, Entity? right)
    {
        return !(left == right);
    }
}
