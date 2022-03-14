using Blueprint.Application.Interfaces.DomainServices.Security;
using Blueprint.Application.Models.Security;
using Blueprint.Application.Result;
using Microsoft.AspNetCore.Mvc;

namespace Blueprint.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task <ActionResult<IEnumerable<UserResponse>>> GetUsersAsync()
        {
            var response = new List<UserResponse>();

            var result = await _userService.GetUsersAsync();

            if (result.Status == ResultStatus.Ok)
            {
                response = new List<UserResponse>(result.Value.Select(item => new UserResponse
                {
                    UserName = item.UserName,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    EmailAddress = item.EmailAddress,
                    IsActive = item.IsActive
                }));
            }
            else if (result.Status == ResultStatus.NotFound)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("get2")]
        public async Task<IActionResult> GetUsersAsync2()
        {
            var response = new List<UserResponse>();

            var result = await _userService.GetUsersAsync();

            if (result.Status == ResultStatus.Ok)
            {
                response = new List<UserResponse>(result.Value.Select(item => new UserResponse
                {
                    UserName = item.UserName,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    EmailAddress = item.EmailAddress,
                    IsActive = item.IsActive
                }));
            }
            else if (result.Status == ResultStatus.NotFound)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}
