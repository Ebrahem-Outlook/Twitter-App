
using Application.Core.Abstraction.Messaging;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Users.Query.GetAll;

/// <summary>
/// Represent the GetAllUsers Handler .
/// </summary>
public sealed class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, List<User>>
{
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Create new instance of <see cref="GetAllUsersQueryHandler"/> class.
    /// </summary>
    /// <param name="userRepository">The database connection.</param>
    public GetAllUsersQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    /// <summary>
    /// The Method to handle in comming request.
    /// </summary>
    /// <param name="request">The Request comming.</param>
    /// <param name="cancellationToken">The cancellationToken.</param>
    /// <returns>The List of user.</returns>
    public async Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAll();

        // Event Getll users.

        return users;
    }
}

