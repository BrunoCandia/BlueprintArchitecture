using Blueprint.Application.Models.Security;
using Blueprint.Application.Models.Result;

namespace Blueprint.Application.Interfaces.DomainServices.Security
{
    public interface IUserService
    {
        Task<Result<IEnumerable<UserResponse>>> GetUsersAsync();
    }
}
