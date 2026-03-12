namespace FlowSign.Application.Commands.Auth.LoginUser;

public class LoginUserCommand
{
    public string Email { get; init; } = null!;
    public string Password { get; init; } = null!;
}
