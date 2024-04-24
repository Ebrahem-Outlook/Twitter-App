using Application.Core.Abstraction.Messaging;
using Domain.Entities;

namespace Application.Users.Query.GetByEmail;

/// <summary>
/// Represent the GetByIdUser Query.
/// </summary>
/// <param name="id">The identifer of the user.</param>
public sealed record GetByEmailUserQuery(string Email) : IQuery<User>;
