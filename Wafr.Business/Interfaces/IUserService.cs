using Wafr.DTOs.Users;

namespace Wafr.Business.Interfaces
{
    public interface IUserService
    {
        UserResponseDTO NewUserRegister(RegisterUserRequestDTO NewUserRegister);

        LoginRequestDTO Login(LoginRequestDTO LoginRequest);

    }
}