
using Application.Core.Abstraction.Messaging;
using Domain.Entities;

namespace Application.Users.Query.GetAll;

/// <summary>
/// Represent the GetAllUser Query.
/// </summary>
public sealed record GetAllUsersQuery : IQuery<List<User>>;


