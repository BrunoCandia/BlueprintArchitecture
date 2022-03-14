namespace Blueprint.Domain.Entities
{
    public class User
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string? Password { get; set; }

        public string? EmailAddress { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<UserToGroup> UserToGroups { get; set; } = new HashSet<UserToGroup>();

        public virtual ICollection<UserToPermission> UserToPermissions { get; set; } = new HashSet<UserToPermission>();

        public virtual ICollection<UserToRole> UserToRoles { get; set; } = new HashSet<UserToRole>();
    }
}
