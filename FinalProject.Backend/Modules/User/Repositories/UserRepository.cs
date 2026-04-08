using FinalProject.Backend.Data.DbContext;
using FinalProject.Backend.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Backend.Modules.User.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public UserRepository(AppDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }
    public Task<bool> DisableUserAsync(string userId)
    {
        var user = _userManager.Users.FirstOrDefault(u => u.Id == userId);
        if (user == null)
        {
            return Task.FromResult(false);
        }
        user.IsActive = false;
        var result = _userManager.UpdateAsync(user).Result;
        return Task.FromResult(result.Succeeded);
    }

    public Task<ApplicationUser?> GetUserByUsernameAsync(string username)
    {
        return Task.FromResult(_userManager.Users.FirstOrDefault(u => u.UserName == username));
        throw new NotImplementedException();
    }

    public Task<bool> UpdateUserAsync(ApplicationUser user)
    {
        var result = _userManager.UpdateAsync(user).Result;
        return Task.FromResult(result.Succeeded);
        throw new NotImplementedException();
    }
}
