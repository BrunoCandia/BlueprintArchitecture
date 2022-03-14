using Blueprint.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blueprint.Infraestructure.Configuration
{
    public class UserToPermissionConfiguration : IEntityTypeConfiguration<UserToPermission>
    {
        public void Configure(EntityTypeBuilder<UserToPermission> builder)
        {
            builder.HasKey(up => new { up.UserName, up.PermissionId });
            builder.HasOne(up => up.User).WithMany(up => up.UserToPermissions);
            builder.HasOne(up => up.Permission).WithMany(up => up.PermissionToUsers);
        }
    }
}
