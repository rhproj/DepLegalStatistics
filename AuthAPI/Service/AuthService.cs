using AuthAPI.Models.Dto;
using AuthAPI.Service.IService;

namespace AuthAPI.Service
{
    public class AuthService : IAuthService
    {
        public Task<bool> AssignRole(string email, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<string> Register(RegistrationRequestDto registrationRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
