using Application.Core.Abstraction.Messaging;
using Domain.Entities;

namespace Application.Users.Query.GetById;

/// <summary>
/// Represent the GetByEmail Query.
/// </summary>
/// <param name="email">The uniqe email of user.</param>
public sealed record GetByIdUserQuery(Guid Id) : IQuery<User>;

