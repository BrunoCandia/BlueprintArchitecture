namespace Blueprint.Domain.Entities
{
    public class Role
    {
        public Guid RoleId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool? IsActive { get; set; }

        public virtual ICollection<GroupToRole> RoleToGroups { get; set; } = new HashSet<GroupToRole>();

        public virtual ICollection<RoleToPermission> RoleToPermissions { get; set; } = new HashSet<RoleToPermission>();

        public virtual ICollection<UserToRole> RoleToUsers { get; set; } = new HashSet<UserToRole>();
    }
}
