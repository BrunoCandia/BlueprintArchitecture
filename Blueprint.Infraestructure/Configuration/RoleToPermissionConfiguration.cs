using Blueprint.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blueprint.Infraestructure.Configuration
{
    public class RoleToPermissionConfiguration : IEntityTypeConfiguration<RoleToPermission>
    {
        public void Configure(EntityTypeBuilder<RoleToPermission> builder)
        {
            builder.HasKey(rt => new { rt.RoleId, rt.PermissionId });
            builder.HasOne(rt => rt.Role).WithMany(rt => rt.RoleToPermissions);
            builder.HasOne(rt => rt.Permission).WithMany(rt => rt.PermissionToRoles);
        }
    }
}
