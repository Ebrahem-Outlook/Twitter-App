using Domain.Core.Primitives;

namespace Domain.Entities;

/// <summary>
/// Represint the <see cref="User"/> Entity class.
/// </summary>
public class User : AggregateRoot
{
    /// <summary>
    /// Create instance of <see cref="User"/> class.
    /// </summary>
    /// <param name="firstName">The FirstName of User instance.</param>
    /// <param name="lastName">The LastName of User instance.</param>
    /// <param name="email">The Email of User instance.</param>
    /// <param name="password">The Password of User instance.</param>
    private User(string firstName, string lastName, string email, string password)
        : base(Guid.NewGuid())
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }
    /// <summary>
    /// Required by EF Core.
    /// </summary>
    private User() { }

    /// <summary>
    /// Get and Set FirstName of User Object.
    /// </summary>
    public string FirstName { get; private set; } = string.Empty;

    /// <summary>
    /// Get and Set LastName of User Object.
    /// </summary>
    public string LastName { get; private set; } = string.Empty;

    /// <summary>
    /// Get and Set Email of User Object.
    /// </summary>
    public string Email { get; private set; } = string.Empty;

    /// <summary>
    /// Get and Set Password of User Object.
    /// </summary>
    public string Password { get; private set; } = string.Empty;

    /// <summary>
    /// Controller the creation instances of User
    /// </summary>
    /// <param name="firstName">The FirstName of User instance.</param>
    /// <param name="lastName">The LastName of User instance.</param>
    /// <param name="email">The Email of User instance.</param>
    /// <param name="password">The Password of User instance.</param>
    /// <returns>New instance of <see cref="User"/> class.</returns>
    public static User Create(string firstName, string lastName, string email, string password)
    {
        var user = new User(firstName, lastName, email, password);

        // Domain Event Create user.

        return user;
    }

    /// <summary>
    /// Update the name of user
    /// </summary>
    /// <param name="firstName">The new firstName of user.</param>
    /// <param name="lastName">The new lastName of user.</param>
    /// <exception cref="ArgumentNullException">We will handled in the futher</exception>
    public void UpdateName(string firstName, string lastName)
    {
        if (firstName is null || lastName is null)
        {
            throw new ArgumentNullException();
        }

        FirstName = firstName;
        LastName = lastName;

        // Domain Event Update uset name;
    }

    /// <summary>
    /// Update the email of user.
    /// </summary>
    /// <param name="email">The new email of user.</param>
    /// /// <exception cref="ArgumentNullException">We will handled in the futher</exception>
    public void UpdateEmail(string email)
    {
        if (email is null)
        {
            throw new ArgumentNullException();
        }

        Email = email;

        // Domain Event Update uset email;
    }

    /// <summary>
    /// Update the password of user.
    /// </summary>
    /// <param name="password"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public void UpdatePassword(string password)
    {
        if (password is null)
        {
            throw new ArgumentNullException();
        }

        Password = password;

        // Domain Event Update uset password;
    }
    
}
