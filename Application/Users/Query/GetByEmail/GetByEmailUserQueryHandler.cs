using Application.Core.Abstraction.Messaging;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Users.Query.GetByEmail;

/// <summary>
/// Represent the GetByEmail Handler.
/// </summary>
internal sealed class GetByEmailUserQueryHandler : IQueryHandler<GetByEmailUserQuery, User>
{
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Create new instance of <see cref="GetByEmailUserQueryHandler"/> class.
    /// </summary>
    /// <param name="userRepository"></param>
    public GetByEmailUserQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    /// <summary>
    /// Handle InComming Request.
    /// </summary>
    /// <param name="request">The InComming Request.</param>
    /// <param name="cancellationToken">The cancellationToken.</param>
    /// <returns>The User from the Database.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task<User> Handle(GetByEmailUserQuery request, CancellationToken cancellationToken)
    {
        var user = _userRepository.GetByEmail(request.Email);

        if(user is null)
        {
            throw new NullReferenceException();
        }

        // Event Get User by email.

        return user;
    }
}
