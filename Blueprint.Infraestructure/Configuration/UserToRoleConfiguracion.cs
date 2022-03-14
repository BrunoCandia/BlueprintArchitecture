using Blueprint.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blueprint.Infraestructure.Configuration
{
    public class UserToRoleConfiguracion : IEntityTypeConfiguration<UserToRole>
    {
        public void Configure(EntityTypeBuilder<UserToRole> builder)
        {
            builder.HasKey(ur => new { ur.UserName, ur.RoleId });
            builder.HasOne(ur => ur.User).WithMany(ur => ur.UserToRoles);
            builder.HasOne(ur => ur.Role).WithMany(ur => ur.RoleToUsers);
        }
    }
}
