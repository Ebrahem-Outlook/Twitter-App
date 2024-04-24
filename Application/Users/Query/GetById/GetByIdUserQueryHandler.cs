using Application.Core.Abstraction.Messaging;
using Application.Users.Query.GetByEmail;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Users.Query.GetById;

/// <summary>
/// Represent the GetByEmail Handler
/// </summary>
internal sealed class GetByIdUserQueryHandler : IQueryHandler<GetByIdUserQuery, User>
{
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Create new instance of <see cref="GetByEmailUserQueryHandler"/> class.
    /// </summary>
    /// <param name="userRepository">The Database connection.</param>
    public GetByIdUserQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    /// <summary>
    /// Method to Handler InComming Request.
    /// </summary>
    /// <param name="request">The InComming Request.</param>
    /// <param name="cancellationToken">The cancellationToken.</param>
    /// <returns>Spicifiec User form database.</returns>
    public async Task<User> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetById(request.Id);

        if(user is null)
        {
            throw new NullReferenceException();
        }

        // Event Get user by email.

        return user;
    }
}

