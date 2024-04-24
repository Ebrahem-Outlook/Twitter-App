using Application.Core.Abstraction.Messaging;

namespace Application.Users.Command.Update;

/// <summary>
/// Represent the update uset command record.
/// </summary>
/// <param name="Id">The identifer of user.</param>
/// <param name="FirstName">The new FirstName of user.</param>
/// <param name="LastName">The new LastName of user.</param>
/// <param name="Email">The new Email of user.</param>
/// <param name="Password">The new Password of user.</param>
public sealed record UpdateUserCommand(Guid Id, string FirstName, string LastName, string Email, string Password) : ICommand<bool>;
