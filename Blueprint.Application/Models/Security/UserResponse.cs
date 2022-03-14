namespace Blueprint.Application.Models.Security;

public class UserResponse
{
    public string UserName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? EmailAddress { get; set; } = string.Empty;
    public bool? IsActive { get; set; }
}
