namespace Blueprint.Domain.Entities
{
    public class Permission
    {
        public Guid PermissionId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool? IsActive { get; set; }

        public string? Namespace { get; set; }

        public virtual ICollection<GroupToPermission> PermissionToGroups { get; set; } = new HashSet<GroupToPermission>();

        public virtual ICollection<RoleToPermission> PermissionToRoles { get; set; } = new HashSet<RoleToPermission>();

        public virtual ICollection<UserToPermission> PermissionToUsers { get; set; } = new HashSet<UserToPermission>();
    }
}
