using Application.Core.Abstraction.Messaging;

namespace Application.Users.Command.Create;

/// <summary>
/// Represent the create user command record.
/// </summary>
/// <param name="FirstName">The firstName of new user</param>
/// <param name="LastName">The lastName of new user</param>
/// <param name="Email">The email of new user</param>
/// <param name="Password">The password of new user</param>
public sealed record CreateUserCommand(string FirstName, string LastName, string Email, string Password) : ICommand<bool>;

