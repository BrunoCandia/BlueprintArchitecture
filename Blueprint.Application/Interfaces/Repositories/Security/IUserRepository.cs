using Blueprint.Application.Models.Security;

namespace Blueprint.Application.Interfaces.Repositories.Security
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserResponse>> GetUsersAsync();
    }
}
