using Application.Core.Abstraction.Messaging;

namespace Application.Users.Command.Delete;

/// <summary>
/// Represent the delete user command record.
/// </summary>
/// <param name="Id">The identifer of user will be deleted.</param>
public sealed record DeleteUserCommand(Guid Id) : ICommand<bool>;

