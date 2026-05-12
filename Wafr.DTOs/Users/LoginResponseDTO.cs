namespace Wafr.DTOs.Users
{
    public class LoginResponseDTO
    {
        public int UserID { get; set; }
        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Token { get; set; } = string.Empty;
    }
}