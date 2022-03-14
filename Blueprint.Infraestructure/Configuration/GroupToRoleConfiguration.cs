using Blueprint.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blueprint.Infraestructure.Configuration
{
    public class GroupToRoleConfiguration : IEntityTypeConfiguration<GroupToRole>
    {
        public void Configure(EntityTypeBuilder<GroupToRole> builder)
        {
            builder.HasKey(gr => new { gr.GroupId, gr.RoleId });
            builder.HasOne(gr => gr.Group).WithMany(gr => gr.GroupToRoles);
            builder.HasOne(gr => gr.Role).WithMany(gr => gr.RoleToGroups);
        }
    }
}
