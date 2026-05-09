namespace Wafr.DTOs.Users;

public class RegisterUserRequestDTO
{
    public string Username { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
}