namespace Blueprint.Domain.Entities
{
    public class UserToPermission
    {
        public string UserName { get; set; } = null!;

        public User User { get; set; } = null!;

        public Guid PermissionId { get; set; }

        public Permission Permission { get; set; } = null!;
    }
}
