using Blueprint.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blueprint.Infraestructure.Configuration
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(g => g.GroupId);
            builder.Property(g => g.GroupId).HasDefaultValueSql("NEWID()");
            builder.Property(g => g.Name).HasMaxLength(100).IsRequired();
            builder.Property(g => g.Description).HasMaxLength(100).IsRequired();
            builder.Property(g => g.IsActive).HasDefaultValue(true).IsRequired();

            builder.HasIndex(g => g.Name).IsUnique();
        }
    }
}
