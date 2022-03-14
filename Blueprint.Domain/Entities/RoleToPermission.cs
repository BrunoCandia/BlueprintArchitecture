namespace Blueprint.Domain.Entities
{
    public class RoleToPermission
    {
        public Guid RoleId { get; set; }

        public Role Role { get; set; } = null!;

        public Guid PermissionId { get; set; }

        public Permission Permission { get; set; } = null!;
    }
}
