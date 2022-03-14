namespace Blueprint.Domain.Entities
{
    public class UserToRole
    {
        public string UserName { get; set; } = null!;

        public User User { get; set; } = null!;

        public Guid RoleId { get; set; }

        public Role Role { get; set; } = null!;
    }
}
