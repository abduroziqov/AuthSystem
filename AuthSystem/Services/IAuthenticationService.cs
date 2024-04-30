using AuthSystem.DTOs;

namespace AuthSystem.Services
{
	public interface IAuthenticationService
	{
		Task<string> Register(RegisterRequest request);
		Task<string> Login(LoginRequest request);
	}
}
