using Blueprint.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blueprint.Infraestructure.Configuration
{
    public class GroupToPermissionConfiguration : IEntityTypeConfiguration<GroupToPermission>
    {
        public void Configure(EntityTypeBuilder<GroupToPermission> builder)
        {
            builder.HasKey(gp => new { gp.GroupId, gp.PermissionId });
            builder.HasOne(gp => gp.Group).WithMany(gp => gp.GroupToPermissions);
            builder.HasOne(gp => gp.Permission).WithMany(gp => gp.PermissionToGroups);
        }
    }
}
