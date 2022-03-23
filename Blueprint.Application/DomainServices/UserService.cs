using Blueprint.Application.Interfaces.DomainServices.Security;
using Blueprint.Application.Interfaces.Repositories.Security;
using Blueprint.Application.Models.Security;
using Blueprint.Application.Models.Result;

namespace Blueprint.Application.DomainServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result<IEnumerable<UserResponse>>> GetUsersAsync()
        {
            var users = await _userRepository.GetUsersAsync();

            if (!users.Any())
            {
                return Result<IEnumerable<UserResponse>>.NotFound();
            }

            return new Result<IEnumerable<UserResponse>>(users);
        }
    }
}
