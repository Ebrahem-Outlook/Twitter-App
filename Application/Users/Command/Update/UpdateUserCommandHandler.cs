using Application.Core.Abstraction.Messaging;
using Domain.Interfaces;

namespace Application.Users.Command.Update;

/// <summary>
/// Represent the update user command handler.
/// </summary>
internal sealed class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand, bool>
{
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Create new instance of <see cref="IUserRepository"/> class.
    /// </summary>
    /// <param name="userRepository">The database connection.</param>
    public UpdateUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    /// <summary>
    /// Method to Handler Request.
    /// </summary>
    /// <param name="request">The Request comming.</param>
    /// <param name="cancellationToken">The cancellationToken.</param>
    /// <returns>The Response of the Request.</returns>
    public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var user = await _userRepository.GetById(request.Id);

            user.UpdateName(request.FirstName, request.LastName);
            user.UpdateEmail(request.Email);
            user.UpdatePassword(request.Password);

            // Event Upate user command.

            // DaveChanges on the stage.

            return true;
        }
        catch (Exception)
        {
            return false;
        }   
    }
}