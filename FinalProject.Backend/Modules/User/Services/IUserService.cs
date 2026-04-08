using FinalProject.Backend.Data.Entities;

namespace FinalProject.Backend.Modules.User.Services;

public interface IUserService
{
    Task<ApplicationUser?> GetUserByUsernameAsync(string accessToken);
    Task<bool> UpdateUserAsync(ApplicationUser user);
    Task<bool> DisableUserAsync(string userId);
    Task<bool> RecoverUserAsync(string userId);
}
