using FinalProject.Backend.Data.Entities;

namespace FinalProject.Backend.Modules.User.Services;

// Vể code
public class UserService : IUserService
{
    public Task<bool> DisableUserAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<ApplicationUser?> GetUserByUsernameAsync(string accessToken)
    {
        
        throw new NotImplementedException();
    }

    public Task<bool> RecoverUserAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateUserAsync(ApplicationUser user)
    {
        throw new NotImplementedException();
    }
}
