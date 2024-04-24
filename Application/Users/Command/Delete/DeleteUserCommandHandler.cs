using Application.Core.Abstraction.Messaging;
using Domain.Interfaces;

namespace Application.Users.Command.Delete;

/// <summary>
/// Represent the delete user command handler class.
/// </summary>
internal sealed class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand, bool>
{
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Create new instance of <see cref="IUserRepository"/> interface.
    /// </summary>
    /// <param name="userRepository">The database connection.</param>
    public DeleteUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    /// <summary>
    /// Method to Handler Request.
    /// </summary>
    /// <param name="request">The Request comming.</param>
    /// <param name="cancellationToken">The cancellationToken.</param>
    /// <returns>The Response of the Request.</returns>
    public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        try
        {
            await _userRepository.Delete(request.Id);

            // Event Delete user command.

            // SaveChanges on the stage.

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
