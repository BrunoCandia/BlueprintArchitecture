namespace Blueprint.Domain.Entities
{
    public class UserToGroup
    {
        public string UserName { get; set; } = null!;

        public User User { get; set; } = null!;

        public Guid GroupId { get; set; }
        
        public Group Group { get; set; } = null!;
    }
}
