using FinalProject.Backend.Data.Entities;

namespace FinalProject.Backend.Modules.User.Repositories;

public interface IUserRepository
{
    Task <ApplicationUser?> GetUserByUsernameAsync(string username);
    Task <bool> UpdateUserAsync(ApplicationUser user);
    Task <bool> DisableUserAsync(string userId);
}
