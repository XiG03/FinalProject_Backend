using FinalProject.Backend.Modules.Auth.DTOs;

namespace FinalProject.Backend.Modules.Auth.Repositories;

public interface IAuthRepository
{
    public Task<bool> RegisterAsync(AuthDto authDto);
    public Task<string> LoginAsync(AuthDto authDto);
    public Task<string> LogoutAsync(Guid userId);
    public Task<string> ForgotPasswordAsync(string email);
    public Task<bool> ResetPasswordAsync(string email, string newPassword);
    public Task<bool> UserExistsAsync(string username);
    public Task<TokenResponseDto> RefreshTokenAsync(TokenRequestDto request);
}
