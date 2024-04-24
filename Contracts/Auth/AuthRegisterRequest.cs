namespace Contracts.Auth;

public record AuthRegisterRequest(string firstName, string lastName, string email, string password);

