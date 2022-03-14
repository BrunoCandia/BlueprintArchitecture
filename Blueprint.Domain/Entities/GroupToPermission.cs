namespace Blueprint.Domain.Entities
{
    public class GroupToPermission
    {
        public Guid GroupId { get; set; }

        public Group Group { get; set; } = null!;

        public Guid PermissionId { get; set; }

        public Permission Permission { get; set; } = null!;
    }
}
