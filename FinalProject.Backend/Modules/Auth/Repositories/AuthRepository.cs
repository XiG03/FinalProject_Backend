using FinalProject.Backend.Data.DbContext;
using FinalProject.Backend.Data.Entities;
using FinalProject.Backend.Modules.Auth.DTOs;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Backend.Modules.Auth.Repositories;

public class AuthRepository : IAuthRepository
{
    private readonly AppDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public AuthRepository(AppDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public Task<string> ForgotPasswordAsync(string email)
    {
        throw new NotImplementedException();
    }

    public async Task<string> LoginAsync(AuthDto authDto)
    {
        var user = await _userManager.FindByNameAsync(authDto.Username);
        if(user == null)
        {
            return null;
        }
        
        throw new NotImplementedException();
    }

    public Task<string> LogoutAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<TokenResponseDto> RefreshTokenAsync(TokenRequestDto request)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> RegisterAsync(AuthDto authDto)
    {

        var user = new ApplicationUser();

        user.UserName = authDto.Username;
        user.Email = authDto.Email;
        user.NormalizedUserName = authDto.Username.ToUpper();
        user.NormalizedEmail = authDto.Email.ToUpper();

        await _userManager.CreateAsync(user, authDto.Password);

        return true;

        throw new NotImplementedException();
    }

    public Task<bool> ResetPasswordAsync(string email, string newPassword)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserExistsAsync(string username)
    {
        throw new NotImplementedException();
    }
}
