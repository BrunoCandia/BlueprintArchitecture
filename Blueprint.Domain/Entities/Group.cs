namespace Blueprint.Domain.Entities
{
    public class Group
    {
        public Guid GroupId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool? IsActive { get; set; }

        public virtual ICollection<GroupToPermission> GroupToPermissions { get; set; } = new HashSet<GroupToPermission>();

        public virtual ICollection<GroupToRole> GroupToRoles { get; set; } = new HashSet<GroupToRole>();

        public virtual ICollection<UserToGroup> GroupToUsers { get; set; } = new HashSet<UserToGroup>();
    }
}
