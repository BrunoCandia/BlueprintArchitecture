using Blueprint.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blueprint.Infraestructure.Configuration
{
    public class UserToGroupConfiguration : IEntityTypeConfiguration<UserToGroup>
    {
        public void Configure(EntityTypeBuilder<UserToGroup> builder)
        {
            builder.HasKey(ug => new { ug.UserName, ug.GroupId });
            builder.HasOne(ug => ug.User).WithMany(ug => ug.UserToGroups);
            builder.HasOne(ug => ug.Group).WithMany(ug => ug.GroupToUsers);
        }
    }
}
