namespace FlowSign.Application.Commands.Auth.LoginUser;
using FlowSign.Domain.Enums;
public class LoginUserResponse
{
    public string UserName { get; init; }
    public string Token { get; init; } = string.Empty;
    public Guid UserId { get; init; }
    public string Email { get; init; }
    public UserRole Role { get; init; }
}
