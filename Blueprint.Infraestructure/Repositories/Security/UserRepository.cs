using Blueprint.Application.Interfaces.Repositories.Security;
using Blueprint.Application.Models.Security;
using Microsoft.EntityFrameworkCore;

namespace Blueprint.Infraestructure.Repositories.Security
{
    public class UserRepository : IUserRepository
    {
        private readonly BlueprintContext _blueprintContext;

        public UserRepository(BlueprintContext blueprintContext)
        {
            _blueprintContext = blueprintContext;
        }

        public async Task<IEnumerable<UserResponse>> GetUsersAsync()
        {
            var users = await _blueprintContext.User.AsNoTracking().ToListAsync();

            return users.Select(u => new UserResponse
            {
                UserName = u.UserName,
                EmailAddress = u.EmailAddress,
                FirstName = u.FirstName,
                LastName = u.LastName,
                IsActive = u.IsActive
            });
        }
    }
}
