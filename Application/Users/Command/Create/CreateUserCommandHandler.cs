using Application.Core.Abstraction.Data;
using Application.Core.Abstraction.Messaging;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Users.Command.Create;

internal sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, bool>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    /// <summary>
    /// Create new instance of <see cref="CreateUserCommand"/> class.
    /// </summary>
    /// <param name="userRepository">The connection of database.</param>
    public CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = User.Create(request.FirstName, request.LastName, request.Email, request.Password);

        if(user is null)
        {
            throw new NullReferenceException();
        }

        await _userRepository.Create(user);

        // Evetn create user command.

        return true;
    }
}